using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Find_Nums_Between_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = num1; i <= num2; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
