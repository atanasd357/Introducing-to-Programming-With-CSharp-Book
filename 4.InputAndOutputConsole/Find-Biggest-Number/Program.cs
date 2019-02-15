using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace Find_Biggest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNum = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Input number: ");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 >= biggestNum)
                {
                    biggestNum = num1;
                }
            }

            Console.WriteLine(biggestNum);
        }
    }
}
