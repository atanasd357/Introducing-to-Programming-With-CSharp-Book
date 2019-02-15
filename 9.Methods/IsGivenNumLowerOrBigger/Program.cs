using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace IsGivenNumLowerOrBigger
{
    public class Program
    {
        static void Main(string[] args)
        {         
            int[] arrayNums = FillArray();

            Console.Write("Enter number of the position in array's: ");
            int position = int.Parse(Console.ReadLine());

            string result = FindLargerOrSmaller(arrayNums, position);

            Console.WriteLine("The number in position: {0} {1}", position, result);
        }

        static int[] FillArray()
        {
            Console.Write("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] arrayNums = new int[arraySize];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < arraySize; i++)
            {
                arrayNums[i] = int.Parse(Console.ReadLine());
            }
            return arrayNums;
        }

        public static string FindLargerOrSmaller(int[] arrayNums, int position)
        {
            string result = "";

            if (position == 0 || position == arrayNums.Length - 1)
            {
                if (position == 0 && arrayNums[position] > arrayNums[position + 1])
                {
                    result = "has only one smaller neighbor.";
                }
                else if (position == 0 && arrayNums[position] < arrayNums[position + 1])
                {
                    result = "has only one bigger neighbor.";
                }
                else if (position == arrayNums.Length - 1 && arrayNums[position] > arrayNums[position - 1])
                {
                    result = "has only one smaller neighbor.";
                }
                else if (position == arrayNums.Length - 1 && arrayNums[position] < arrayNums[position - 1])
                {
                    result = "has only one bigger neighbor.";
                }
                else
                {
                    result = "has only one equal neighbor.";
                }
            }
            else if (arrayNums[position] > arrayNums[position + 1] &&
                arrayNums[position] > arrayNums[position - 1])
            {
                result = "is greater than it's two neighboring numbers.";
            }
            else if (arrayNums[position] < arrayNums[position + 1] &&
               arrayNums[position] < arrayNums[position - 1])
            {
                result = "is smaller than it's two neighboring numbers.";
            }
            else if (arrayNums[position] > arrayNums[position + 1] &&
               arrayNums[position] < arrayNums[position - 1] ||
               arrayNums[position] < arrayNums[position + 1] &&
               arrayNums[position] > arrayNums[position - 1]) 
            {
                result = "is greater than one but less than the other neighboring number.";
            }
            else
            {
                result = "is equal to one or both of its neighboring numbers.";
            }

            return result;
        }
    }
}
