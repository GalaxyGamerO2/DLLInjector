using DLLInjector.Layouts;
using DLLInjector.Properties;
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

        public List<LayoutData> LayoutData { get; set;}

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
        [JsonIgnore]
        public Bitmap TitleImage { get; set; }
        [JsonIgnore]
        public Stream InjectionSuccessSound { get; set; }

        public Theme()
        {
            Name = "Default";

            PrimaryColorHex = "#FF404040";
            SecondaryColorHex = "#FF202020";
            ButtonColorHex = SecondaryColorHex;
            ForeColorHex = "#FFFFFFFF";
            LayoutData = new()
            {
                new LayoutData()
                {
                    Name = "TitlePB",
                    X = 12,
                    Y = 12,
                    Width = 776,
                    Height = 100
                },
                new LayoutData()
                {
                    Name = "DllLabel",
                    X = 12,
                    Y = 122,
                    Width = 30,
                    Height = 15
                },
                new LayoutData()
                {
                    Name = "DllPathTB",
                    X = 48,
                    Y = 118,
                    Width = 659,
                    Height = 23
                },
                new LayoutData()
                {
                    Name = "BrowseBtn",
                    X = 713,
                    Y = 118,
                    Width = 75,
                    Height = 23
                },
                new LayoutData()
                {
                    Name = "ProcessesLV",
                    X = 12,
                    Y = 147,
                    Width = 776,
                    Height = 262
                },
                new LayoutData()
                {
                    Name = "ReloadBtn",
                    X = 12,
                    Y = 415,
                    Width = 75,
                    Height = 23
                },
                new LayoutData()
                {
                    Name = "ThemesBtn",
                    X = 93,
                    Y = 415,
                    Width = 75,
                    Height = 23
                },
                new LayoutData()
                {
                    Name = "CreditsLabel",
                    X = 520,
                    Y = 419,
                    Width = 187,
                    Height = 15
                },
                new LayoutData()
                {
                    Name = "InjectBtn",
                    X = 713,
                    Y = 415,
                    Width = 75,
                    Height = 23
                },
                new LayoutData()
                {
                    Name = "CloseBtn",
                    X = 753,
                    Y = 12,
                    Width = 35,
                    Height = 33
                },
                new LayoutData()
                {
                    Name = "ThemesFLP",
                    X = 12,
                    Y = 147,
                    Width = 776,
                    Height = 262
                },
            };

            Background = new(800, 450);
            TitleImage = Resources.TitleImage;
            InjectionSuccessSound = Resources.AufDerHeide;
            using Graphics gfx = Graphics.FromImage(Background);
            using SolidBrush brush = new(Color.FromArgb((int)PrimaryColor));
            gfx.FillRectangle(brush, 0, 0, Background.Width, Background.Height);
        }
    }
}
