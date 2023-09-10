using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLInjector.Themes
{
    public class Theme
    {
        public string Name { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Color ButtonColor { get; set; }
        public Color ForeColor { get; set; }
        public Bitmap Background { get; set; }

        public Theme()
        {
            Name = "Default";
            PrimaryColor = Color.FromArgb(64, 64, 64);
            SecondaryColor = Color.FromArgb(32, 32, 32);
            ButtonColor = SecondaryColor;
            ForeColor = Color.FromArgb(255, 255, 255);
            Background = new(800, 450);
            using Graphics gfx = Graphics.FromImage(Background);
            using SolidBrush brush = new(PrimaryColor);
            gfx.FillRectangle(brush, 0, 0, Background.Width, Background.Height);
        }
    }
}
