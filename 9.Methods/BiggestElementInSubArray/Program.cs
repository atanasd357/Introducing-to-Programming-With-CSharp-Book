using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace BiggestElementInSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght: ");
            int arrayLenght = int.Parse(Console.ReadLine());

            int[] arrayNum = FillArray(arrayLenght);

            Console.Write("Enter sub array start position: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter sub array end position: ");
            int endNum = int.Parse(Console.ReadLine());

            int biggerElementSub = FindBiggerElementSub(arrayNum, startNum, endNum);

            Console.WriteLine("The bigger element in sub array from position {0} to position {1} is: {2}",
                startNum, endNum, biggerElementSub);
        }

        static int[] FillArray(int arrayLenght)
        {
            int[] arrayNum = new int[arrayLenght];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < arrayNum.Length; i++)
            {
                arrayNum[i] = int.Parse(Console.ReadLine());
            }
            return arrayNum;
        }

        static int FindBiggerElementSub(int[] arrayNum, int startNum, int endNum)
        {
            int biggerNumSub = arrayNum[startNum];

            for (int i = startNum + 1; i <= endNum; i++) 
            {
                if (arrayNum[i] > biggerNumSub)
                {
                    biggerNumSub = arrayNum[i];
                }
            }

            return biggerNumSub;
        }
    }
}
