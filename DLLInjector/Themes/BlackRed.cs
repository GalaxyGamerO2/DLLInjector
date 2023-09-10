using DLLInjector.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLInjector.Themes
{
    public class BlackRed : Theme
    {
        public BlackRed()
        {
            Background = Resources.BlackToRedBackground;
            Name = "Black Red";
            PrimaryColor = Color.FromArgb(32, 0, 0);
            SecondaryColor = Color.FromArgb(64, 0, 0);
            ButtonColor = SecondaryColor;
            ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
