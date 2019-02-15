using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace SumOfLongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number for sum: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter second number for sum: ");
            string num2 = Console.ReadLine();

            int[] arrayFirst = FillArray(num1);
            int[] arraySecond = FillArray(num2);

            List<int> Sum = SumArray(arrayFirst, arraySecond);

            for (int i = Sum.Count()-1; i >= 0; i--)
            {
                Console.Write(Sum[i]);
            }
            Console.WriteLine();    
        }

        static int[] FillArray(string inputNum)
        {
            int count = 0;
            int[] arrayTemp = new int[inputNum.Length];

            foreach (int num in inputNum)
            {
                arrayTemp[count] = num - 48;
                count++;
            }

            Array.Reverse(arrayTemp);

            return arrayTemp;
        }

        static List<int> SumArray(int[] arrayFirst, int[] arraySecond)
        {
            int[] longerArray;
            int[] shorterArray;

            if (arrayFirst.Length >= arraySecond.Length)
            {
                longerArray = arrayFirst;
                shorterArray = arraySecond;
            }
            else
            {
                longerArray = arraySecond;
                shorterArray = arrayFirst;
            }

            int tempSum = 0;
            int carry = 0;
            int sum = 0;
            List<int> sumList = new List<int>();

            for (int i = 0; i < longerArray.Length; i++)
            {
                if (i < shorterArray.Length)
                {
                    tempSum = longerArray[i] + shorterArray[i];
                    sum = carry + (tempSum % 10);

                    if (tempSum >= 10)
                    {
                        carry = 1;
                    }
                    else if (sum >= 10)
                    {
                        sum %= 10;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
                else
                {
                    tempSum = longerArray[i] + carry;
                    sum = tempSum % 10;

                    if (tempSum >= 10)
                    {
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }                   
                }
                sumList.Add(sum);
            }

            if (carry != 0)
            {
                sumList.Add(carry);
                return sumList;
            }
            else
            {
                return sumList;
            }
            
        }
    }
}
