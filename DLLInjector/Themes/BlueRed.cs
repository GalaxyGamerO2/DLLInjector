using DLLInjector.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLInjector.Themes
{
    public class BlueRed : Theme
    {
        public BlueRed()
        {
            Background = Resources.BlueToRedBackground;
            Name = "Blue Red";
            PrimaryColor = Color.FromArgb(0, 0, 32);
            SecondaryColor = Color.FromArgb(0, 0, 64);
            ButtonColor = SecondaryColor;
            ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
