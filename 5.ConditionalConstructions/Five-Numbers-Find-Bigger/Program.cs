using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace Five_Numbers_Find_Bigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nums: ");

            int currentNum = int.MinValue;
            int biggerNum = 0;

            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n>currentNum)
                {
                    biggerNum = n;
                }
                currentNum = n;
            }
            Console.WriteLine(biggerNum);
        }
    }
}
