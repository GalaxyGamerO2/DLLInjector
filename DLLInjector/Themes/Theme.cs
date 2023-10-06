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

        public string PrimaryColorHex { get; set; }
        public string SecondaryColorHex { get; set; }
        public string ButtonColorHex { get; set; }
        public string ForeColorHex { get; set; }

        [JsonIgnore]
        public uint PrimaryColor { get { return Convert.ToUInt32(PrimaryColorHex[1..], 16); } set { PrimaryColorHex = "#" + value.ToString("X8"); } }
        [JsonIgnore]
        public uint SecondaryColor { get { return Convert.ToUInt32(SecondaryColorHex[1..], 16); } set { SecondaryColorHex = "#" + value.ToString("X8"); } }
        [JsonIgnore]
        public uint ButtonColor { get { return Convert.ToUInt32(ButtonColorHex[1..], 16); } set { ButtonColorHex = "#" + value.ToString("X8"); } }
        [JsonIgnore]
        public uint ForeColor { get { return Convert.ToUInt32(ForeColorHex[1..], 16); } set { ForeColorHex = "#" + value.ToString("X8"); } }
        [JsonIgnore]
        public Bitmap Background { get; set; }

        public Theme()
        {
            Name = "Default";

            PrimaryColorHex = "#FF404040";
            SecondaryColorHex = "#FF202020";
            ButtonColorHex = SecondaryColorHex;
            ForeColorHex = "#FFFFFFFF";

            Background = new(800, 450);
            using Graphics gfx = Graphics.FromImage(Background);
            using SolidBrush brush = new(Color.FromArgb((int)PrimaryColor));
            gfx.FillRectangle(brush, 0, 0, Background.Width, Background.Height);
        }
    }
}
