using DLLInjector.Themes;
using System.Text.Json;

namespace DLLInjector
{
    public class ThemeManager
    {
        readonly string ThemeDirectory = Path.Combine(Globals.ConfigDirectory, "Themes");
        public List<Theme> Themes { get; private set; }
        public Theme ActiveTheme { get; private set; }

        public ThemeManager()
        {
            Themes = new()
            {
                new(),
                new BlackRed(),
                new BlackPurple(),
                new BlueRed(),
                new NaziCord(),
            };
            if (!Directory.Exists(ThemeDirectory)) Directory.CreateDirectory(ThemeDirectory);

            string[] customThemes = Directory.GetDirectories(ThemeDirectory, "*.theme");

            for (int i = 0; i < customThemes.Length; i++)
            {
                try
                {
                    if (!File.Exists(customThemes[i] + "/theme.json")) continue;
                    Theme? customTheme = JsonSerializer.Deserialize<Theme>(File.ReadAllText(customThemes[i] + "/theme.json"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? throw new("The theme was null.");
                    if (File.Exists(customThemes[i] + "/background.png")) customTheme.Background = new(customThemes[i] + "/background.png");
                    if (File.Exists(customThemes[i] + "/title.png")) customTheme.TitleImage = new(customThemes[i] + "/title.png");
                    if (File.Exists(customThemes[i] + "/inject.wav")) customTheme.InjectionSuccessSound = new FileStream(customThemes[i] + "/inject.wav", FileMode.Open);
                    Themes.Add(customTheme);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load theme '{Path.GetFileNameWithoutExtension(customThemes[i])}': '{ex.Message}'");
                }
            }

            ActiveTheme = new();
        }

        public void SetTheme(Theme theme)
        {
            ActiveTheme = theme;
        }
    }
}
