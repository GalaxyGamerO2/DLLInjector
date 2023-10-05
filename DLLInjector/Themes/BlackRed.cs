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
            PrimaryColor = 0xFF200000;
            SecondaryColor = 0xFF400000;
            ButtonColor = SecondaryColor;
            ForeColor = 0xFFFFFFFF;
        }
    }
}
