using DLLInjector.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLInjector.Themes
{
    public class NaziCord : Theme
    {
        public NaziCord()
        {
            Background = Resources.NaziCordBackground;
            Name = "Nazicord";
            PrimaryColor = 0xFF313338;
            SecondaryColor = 0xFF2b2d31;
            ButtonColor = 0xFF5865f2;
            ForeColor = 0xFFf2f3f5;
        }
    }
}
