using System.Drawing;

namespace TheRayTracerChallenge
{
    public class Canvas
    {
        public int Width { get; }
        public int Height { get; }
        public Color[][] Pixels { get; }

        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;
            Pixels = new Color[Width][];
            for (int i = 0; i < Width; i++)
            {
                Pixels[i] = new Color[Height];
                for (int j = 0; j < Height; j++)
                {
                    Pixels[i][j] = Color.Black;
                }
            }
        }

        public Color[] this[int y]
        {
            get => Pixels[y];
        }

        public void SetPixel(int x, int y, Color c)
        {
            Pixels[x][y] = c;
        }
        public Color GetPixel(int x, int y) => Pixels[x][y];

        public void Save(string file)
        {
            var b = new Bitmap(this.Width, this.Height);
            for (int y = 0; y < this.Height; y++)
            {
                for (int x = 0; x < this.Width; x++)
                {
                    var p = this.GetPixel(x, y);
                    b.SetPixel(x, y, System.Drawing.Color.FromArgb(Color.Normalize(p.Red),
                        Color.Normalize(p.Green), Color.Normalize(p.Blue)));
                }
            }
            b.Save(file);
        }
    }
}