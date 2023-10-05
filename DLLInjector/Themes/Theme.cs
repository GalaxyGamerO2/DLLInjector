using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DLLInjector.Themes
{
    public class Theme
    {
        public string Name { get; set; }
        public uint PrimaryColor { get; set; }
        public uint SecondaryColor { get; set; }
        public uint ButtonColor { get; set; }
        public uint ForeColor { get; set; }

        [JsonIgnore]
        public Bitmap Background { get; set; }

        public Theme()
        {
            Name = "Default";
            PrimaryColor = 0xFF404040;
            SecondaryColor = 0xFF202020;
            ButtonColor = SecondaryColor;
            ForeColor = 0xFFFFFFFF;
            Background = new(800, 450);
            using Graphics gfx = Graphics.FromImage(Background);
            using SolidBrush brush = new(Color.FromArgb((int)PrimaryColor));
            gfx.FillRectangle(brush, 0, 0, Background.Width, Background.Height);
        }
    }
}
