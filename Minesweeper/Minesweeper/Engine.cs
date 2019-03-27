using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Minesweeper
{
    public static class Engine
    {
        public static int n, percent, x = 25;
        public static int[,] matrix;
        public static MainWindow MainWindow;

        public static void Initialization(MainWindow mainWindow)
        {
            n = 500 / x;
            percent = 7;
            matrix = new int[n, n];
            MainWindow = mainWindow;

            Random r = new Random();
            int mines = n * n / percent;
            for (int k = 0; k < mines; k++)
            {
                bool ok = true;
                while (ok)
                {
                    int i = r.Next(n), j = r.Next(n);
                    if (matrix[i, j] == 0 && (i < n / 2 - 1 || i > n / 2 + 1) && (j < n / 2 - 1 || j > n / 2 + 1))
                    {
                        matrix[i, j] = 9;
                        ok = false;
                    }
                }
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] == 9)
                    {
                        for (int k = i - 1; k <= i + 1; k++)
                            for (int l = j - 1; l <= j + 1; l++)
                            {
                                if (k >= 0 && k < n && l >= 0 && l < n)
                                    if (matrix[k, l] != 9)
                                        matrix[k, l]++;
                            }
                    }

            Resources.Initialization();
        }


    }
}
