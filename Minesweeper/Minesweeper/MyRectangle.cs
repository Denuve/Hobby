using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Minesweeper
{
    public class MyRectangle
    {
        Rectangle tile;
        int value;
        Color c;

        public MyRectangle(int i, int j, int v)
        {
            tile = new Rectangle();
            Engine.MainWindow.Main.Children.Add(tile);
            tile.RenderSize = new Size(Engine.x - 2, Engine.x - 2);
            tile.Margin = new Thickness(j * Engine.x, i * Engine.x, 0, 0);
            value = v;
            switch (v)
            {
                case 1: c = Color.FromRgb(20, 100, 200); break;
                case 2: c = Color.FromRgb(0, 255, 0); break;
                case 3: c = Color.FromRgb(255, 0, 0); break;
                case 4: c = Color.FromRgb(0, 0, 55); break;
                case 5: c = Color.FromRgb(55, 0, 0); break;
                case 6: c = Color.FromRgb(0, 206, 209); break;
                case 7: c = Color.FromRgb(0, 0, 0); break;
                case 8: c = Color.FromRgb(55, 55, 55); break;
                default: break;
            }
            
        }
    }
}
