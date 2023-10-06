using DLLInjector.Properties;

namespace DLLInjector.Themes
{
    public class BlueRed : Theme
    {
        public BlueRed()
        {
            Background = Resources.BlueToRedBackground;
            Name = "Blue Red";
            PrimaryColor = 0xFF000020;
            SecondaryColor = 0xFF000040;
            ButtonColor = SecondaryColor;
            ForeColor = 0xFFFFFFFF;
        }
    }
}
