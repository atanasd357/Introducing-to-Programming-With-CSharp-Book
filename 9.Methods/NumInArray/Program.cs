using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace GivenNumInArray
{
    public class GivenNumInArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num for find: ");
            int num = int.Parse(Console.ReadLine());

            int[] arrayNums = FillArray();
            int count = FindNum(num, arrayNums);

            Console.WriteLine("The number: {0} is met {1} times in given array", num, count);
        }

        public static int FindNum(int num, int[] arrayNums)
        {
            int count = 0;

            for (int i = 0; i < arrayNums.Length; i++)
            {
                if (arrayNums[i] == num)
                {
                    count++;
                }
            }

            return count;
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
    }
}
