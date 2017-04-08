using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Labyrinth
{
    class Labyrinth
    {
        static Queue<Cell> queue = new Queue<Cell>();
        static Cell currentCell = new Cell(2, 1, 0);
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
           
            queue.Enqueue(currentCell);
            while (queue.Count > 0)
            {
                currentCell = queue.Dequeue();
                int currentRow = currentCell.Row;
                int currentCol = currentCell.Col;
                int currentDistance = currentCell.Distance;
                if(lab[currentRow, currentCol] != "*")
                {
                    lab[currentRow, currentCol] = currentDistance.ToString();

                }
                currentDistance += 1;
                checkValidCell(currentRow, currentCol + 1, currentDistance);
                checkValidCell(currentRow + 1, currentCol, currentDistance);
                checkValidCell(currentRow, currentCol - 1, currentDistance);
                checkValidCell(currentRow - 1, currentCol, currentDistance);


            }

            Console.WriteLine(printLabyrinth(lab));
        }

        private static void checkValidCell(int row, int col, int distance)
        {
            if (row < 0 || row >= height || col < 0 || col >= width)
            {
                return;
            }
            if(lab[row,col] != "0" || lab[row, col] == "*")
            {
                return;
            }
            //int currentIntValue;
           
            //if (int.TryParse(lab[row, col], out currentIntValue))
            //{
            //    if(currentIntValue >= distance)
            //    {
            //        return;
            //    }
            //}
            else
            {
                queue.Enqueue(new Cell(row, col, distance));
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
                    if(lab[i,j] == "0")
                    {
                        sb.Append("u ");
                    }
                    else
                    {
                        sb.Append(lab[i, j] + " ");
                    }
                   
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
