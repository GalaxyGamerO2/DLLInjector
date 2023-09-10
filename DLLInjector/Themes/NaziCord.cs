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
            PrimaryColor = Color.FromArgb(49, 51, 56);
            SecondaryColor = Color.FromArgb(43, 45, 49);
            ButtonColor = Color.FromArgb(88, 101, 242);
            ForeColor = Color.FromArgb(242, 243, 245);
        }
    }
}
