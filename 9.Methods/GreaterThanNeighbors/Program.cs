using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace GreaterThanNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums = FillArray();

            int result = FindGreaterThanNeighbors(arrayNums);

            if (result == -1)
            {
                Console.WriteLine("There is no such number!");
            }
            else
            {
                Console.Write("The position of the number is: ");
            }

            Console.WriteLine(result);
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

        static int FindGreaterThanNeighbors(int[] arrayNums)
        {
            int result = -1;
            bool isThereNum = false;

            for (int i = 1; i < arrayNums.Length - 1; i++) 
            {
                if (arrayNums[i] > arrayNums[i - 1] && arrayNums[i] > arrayNums[i + 1])
                {
                    result = i;
                    isThereNum = true;
                    break;
                }
            }

            if (isThereNum) 
            {
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
