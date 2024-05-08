using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace DLLInjector
{
    internal static class Program
    {
        static bool NoGUI = false;
        static bool NoApp = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            HandleArgs(args);

            if(!NoGUI && !NoApp)
            {
                ApplicationConfiguration.Initialize();
                if (Globals.ThemeManager is null) Globals.Initialize();
                Application.Run(new DLLInjector());
            }
        }

        static void HandleArgs(string[] args)
        {
            int index = 0;
            try
            {
                while (index < args.Length)
                {
                    index += HandleArgument(args, index);
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine($"Invalid arguments. (Argument {index})");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to parse arguments: " + ex.Message);
            }
        }

        static int HandleArgument(string[] args, int index)
        {
            if (args[index] == "/injectDll")
            {
                string dllArgs = args[index + 1];
                string[] dllArgsSplit = dllArgs.Split(":::", 2, StringSplitOptions.RemoveEmptyEntries);

                string dllPath = dllArgsSplit[0];
                string processName = dllArgsSplit[1];

                if (!File.Exists(dllPath))
                {
                    if (NoGUI) Console.WriteLine("DLL not found.");
                    else MessageBox.Show("DLL not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(-1);
                }
                Process? process = Process.GetProcesses().FirstOrDefault(p => Path.GetFileName(GetProcessName(p.Id)) == processName);

                if (process is null)
                {
                    if (NoGUI) Console.WriteLine("Process not found.");
                    else MessageBox.Show("Process not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(-1);
                }

                var result = BasicInject.Inject(process, dllPath);

                if (!result.Item1)
                {
                    if (NoGUI) Console.WriteLine("Failed to inject: " + result.Item2);
                    else MessageBox.Show("Failed to inject: " + result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(-1);
                }

                return 2;
            }

            if (args[index] == "/noGui")
            {
                NoGUI = true;
                return 1;
            }

            if (args[index] == "/noApp")
            {
                NoApp = true;
                return 1;
            }

            return 1;
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

        [DllImport("psapi.dll")]
        static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In][MarshalAs(UnmanagedType.U4)] int nSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetProcessName(int pid)
        {
            var processHandle = OpenProcess(0x0400 | 0x0010, false, pid);

            if (processHandle == IntPtr.Zero)
            {
                return null;
            }

            const int lengthSb = 4000;

            var sb = new StringBuilder(lengthSb);

            string? result = null;

            if (GetModuleFileNameEx(processHandle, IntPtr.Zero, sb, lengthSb) > 0)
            {
                result = Path.GetFileName(sb.ToString());
            }

            CloseHandle(processHandle);

            return result;
        }
    }
}