using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 5

namespace FindSubMatrixWithBiggestSumFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = "Input File.txt";

            StreamReader reader = new StreamReader(inputFileName);

            using (reader)
            {
                int matrixSize = int.Parse(reader.ReadLine());
                int[,] matrix = new int[matrixSize, matrixSize];

                string matrixRow = reader.ReadToEnd();
              
                string[] matrixRowNumbers = matrixRow.Split(new string[] { " " }, 
                    StringSplitOptions.RemoveEmptyEntries);

                int count = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = int.Parse(matrixRowNumbers[count]);
                        count++;
                    }
                }

                int biggestSum = int.MinValue;
                int currentSum = 0;
                int rowPositionMaxSum = 0;
                int colPositionMaxSum = 0;

                for (int row = 0; row < matrix.GetLength(0) - 1; row++) 
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++) 
                    {
                        currentSum = matrix[row, col] + matrix[row, col + 1] +
                           matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (currentSum > biggestSum) 
                        {
                            biggestSum = currentSum;
                            rowPositionMaxSum = row;
                            colPositionMaxSum = col;
                        }
                        currentSum = 0;
                    }
                }

                StreamWriter writer = new StreamWriter("Result File.txt", false, Encoding.GetEncoding("UTF-8"));

                using (writer)
                {
                    writer.WriteLine("The submatrix with biggest sum is:");
                    writer.WriteLine(matrix[rowPositionMaxSum, colPositionMaxSum] + " " +
                        matrix[rowPositionMaxSum, colPositionMaxSum + 1] + Environment.NewLine +
                        matrix[rowPositionMaxSum + 1, colPositionMaxSum] + " " +
                        matrix[rowPositionMaxSum + 1, colPositionMaxSum + 1]);
                    writer.WriteLine(Environment.NewLine + "Sum = {0}", biggestSum);
                }
            }
        }
    }
}
