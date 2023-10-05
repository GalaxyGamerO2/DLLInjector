using DLLInjector.Themes;
using System.Text.Json;

namespace DLLInjector
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            File.WriteAllText("./nazicord.json", JsonSerializer.Serialize(new NaziCord(), new JsonSerializerOptions() { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase}));
            ApplicationConfiguration.Initialize();
            Application.Run(new DLLInjector());
        }
    }
}