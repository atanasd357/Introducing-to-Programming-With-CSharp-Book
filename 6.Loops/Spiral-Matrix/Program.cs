using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 18

namespace Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input array size: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrixArray = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "right";

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (col > n - 1 || matrixArray[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrixArray[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrixArray[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrixArray[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrixArray[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,4}", matrixArray[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
