using System.Drawing;

namespace RainbowSort
{
    public static class Resources
    {
        public static int n = 305;
        public static Colour[] rainbow = new Colour[n];
        public static Bitmap bmp = new Bitmap(Engine.display.Width, Engine.display.Height);
        public static Graphics grp = Graphics.FromImage(bmp);

        public static void GenerateRainbow()
        {
            int r = 255, g = 0, b = 0;
            for (int i = 0; i < 51; i++)
                rainbow[i] = new Colour(Color.FromArgb(r, g+=5, b), i);
            for (int i = 51; i < 102; i++)
                rainbow[i] = new Colour(Color.FromArgb(r -= 5, g, b), i);
            for (int i = 102; i < 153; i++)
                rainbow[i] = new Colour(Color.FromArgb(r, g, b += 5), i);
            for (int i = 153; i < 204; i++)
                rainbow[i] = new Colour(Color.FromArgb(r, g -= 5, b), i);
            for (int i = 204; i < 255; i++)
                rainbow[i] = new Colour(Color.FromArgb(r += 5, g, b), i);
            for (int i = 255; i < n; i++)
                rainbow[i] = new Colour(Color.FromArgb(r, g, b -= 5), i);
        }

        public static void ShowRainbow()
        {
            for (int i = 0; i < n; i++)
                Draw(i);
        }

        public static void Draw(int i)
        {
            grp.DrawLine(new Pen(rainbow[i].colour, 2), i * 2, 0, i * 2, Engine.display.Height);
            Engine.display.Image = bmp;
        }
    }
}
