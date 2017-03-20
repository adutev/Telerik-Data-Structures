using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Labyrinth
{
    class Labyrinth
    {
        const int width = 6;
        const int height = 6;
        static string[,] lab =
            {
            {"0","0","0","x","0","x"},
            {"0","x","0","x","0","x"},
            {"0","*","x","0","x","0"},
            {"0","x","0","0","0","0"},
            {"0","0","0","x","x","0"},
            {"0","0","0","x","0","x"},
        };

        static void Main(string[] args)
        {

            findExit(2, 1, 0);
            Console.WriteLine(printLabyrinth(lab));
        }

        private static void findExit(int row, int col, int count)
        {
            if (row < 0 || row >= height || col < 0 || col >= width || isVisited(row, col))
            {
                return;
            }
            else
            {

                lab[row, col] = count.ToString();
                count += 1;
                findExit(row, col + 1, count);
                findExit(row + 1, col, count);
                findExit(row, col - 1, count);
                findExit(row - 1, col, count);

            }

        }

        private static bool isVisited(int row, int col)
        {
            if (lab[row, col] == "0" && lab[row, col] != "x" || lab[row,col] == "*")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static String printLabyrinth(string[,] lab)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sb.Append(lab[i, j] + " ");
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
