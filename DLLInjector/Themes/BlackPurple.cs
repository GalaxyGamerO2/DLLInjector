using DLLInjector.Properties;

namespace DLLInjector.Themes
{
    public class BlackPurple : Theme
    {
        public BlackPurple()
        {
            Background = Resources.BlackToPurpleBackground;
            Name = "Black Purple";
            PrimaryColor = 0xFF150020;
            SecondaryColor = 0xFF100040;
            ButtonColor = SecondaryColor;
            ForeColor = 0xFFFFFFFF;
        }
    }
}
