using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public static class Resources
    {
        public static MyRectangle[,] rectangles;

        public static void Initialization()
        {
            rectangles = new MyRectangle[Engine.n, Engine.n];

            for (int i = 0; i < Engine.n; i++)
                for (int j = 0; j < Engine.n; j++)
                    rectangles[i, j] = new MyRectangle(i, j, Engine.matrix[i, j]);
        }
    }
}
