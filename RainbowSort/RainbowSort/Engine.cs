using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowSort
{
    public static class Engine
    {
        public static PictureBox display;

        public static void Initialize(PictureBox pb)
        {
            display = pb;
            Resources.GenerateRainbow();
            Resources.ShowRainbow();
        }

        public static void Swap(int i, int j)
        {
            Colour c = Resources.rainbow[i];
            Resources.rainbow[i] = Resources.rainbow[j];
            Resources.rainbow[j] = c;
            Resources.ShowRainbow();
            Resources.Draw(i);
            Resources.Draw(j);
            display.Update();
        }

        public static void Shuffle()
        {
            Random r = new Random();
            for(int i=1; i<Resources.n; i++)
            {
                int index = r.Next(i);
                Swap(i, index);
            }
        }

        public static void Bubble()
        {
            int k = 0;
            bool ok;
            do
            {
                ok = false;
                for (int i = 0; i < Resources.n - 1 - k; i++)
                    if (Resources.rainbow[i].value > Resources.rainbow[i + 1].value)
                    {
                        Swap(i, i + 1);
                        ok = true;
                    }
                k++;
            } while (ok);
        }

        public static void Insertion()
        {
            for (int j = 1; j < Resources.n; j++)
                for (int i = j; i > 0; i--)
                    if (Resources.rainbow[i].value < Resources.rainbow[i - 1].value)
                        Swap(i, i - 1);
        }

        public static void Selection()
        {
            for (int j = 0; j < Resources.n; j++)
            {
                int poz = j;
                for (int i = j + 1; i < Resources.n; i++)
                    if (Resources.rainbow[i].value < Resources.rainbow[poz].value)
                        poz = i;
                Swap(j, poz);
            }
        }
    }
}
