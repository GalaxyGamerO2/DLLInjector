using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace DLLInjector
{
    public class BasicInject
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        static extern int CloseHandle(IntPtr hObject);


        public static (bool, string) Inject(Process targetProcess, string dllName)
        {
            try
            {
                if (!File.Exists(dllName)) throw new FileNotFoundException("The provided DLL was not found.");
                int processId = targetProcess.Id;
                IntPtr hProcess = OpenProcess(0x1F0FFF, false, processId);

                IntPtr addr = VirtualAllocEx(hProcess, IntPtr.Zero, (uint)dllName.Length, 0x1000, 0x40);
                WriteProcessMemory(hProcess, addr, Encoding.ASCII.GetBytes(dllName), (uint)dllName.Length, out int bytesWritten);

                IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

                IntPtr hRemoteThread = CreateRemoteThread(hProcess, IntPtr.Zero, 0, loadLibraryAddr, addr, 0, IntPtr.Zero);

                if (hRemoteThread != IntPtr.Zero)
                {
                    _ = CloseHandle(hRemoteThread);
                    return (true, "DLL injected successfully.");
                }

                // Close the process handle.
                _ = CloseHandle(hProcess);

                return (false, "Failed to inject DLL.");
            }
            catch (Exception ex)
            {
                return (false, "Failed to inject DLL: " + ex.Message);
            }
        }
    }
}
