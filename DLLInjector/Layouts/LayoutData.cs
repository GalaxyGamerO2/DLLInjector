namespace DLLInjector.Layouts
{
    public class LayoutData
    {
        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public LayoutData()
        {
            Name = string.Empty;
            X = 0;
            Y = 0;
            Width = 0;
            Height = 0;
        }
    }
}
