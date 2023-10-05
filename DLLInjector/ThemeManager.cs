using DLLInjector.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DLLInjector
{
    public class ThemeManager
    {
        readonly string ThemeDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NaziInjector", "Themes");
        public List<Theme> Themes { get; private set; }
        public ThemeManager()
        {
            Themes = new()
            {
                new(),
                new BlackRed(),
                new BlueRed(),
                new NaziCord(),
            };
            if (!Directory.Exists(ThemeDirectory)) Directory.CreateDirectory(ThemeDirectory);

            string[] customThemes = Directory.GetDirectories(ThemeDirectory, "*.theme");

            for(int i = 0; i < customThemes.Length; i++)
            {
                try
                {
                    if (!File.Exists(customThemes[i] + "/theme.json")) continue;
                    Theme? customTheme = JsonSerializer.Deserialize<Theme>(File.ReadAllText(customThemes[i] + "/theme.json"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? throw new("The theme was null.");
                    if (File.Exists(customThemes[i] + "/background.png"))
                    {
                        customTheme.Background = new(customThemes[i] + "/background.png");
                    }
                    Themes.Add(customTheme);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load theme '{Path.GetFileNameWithoutExtension(customThemes[i])}': '{ex.Message}'");
                }
            }
        }
    }
}
