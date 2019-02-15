using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Number_of_Zeros_in_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());

            double countZeros = 0;

            for (int i = 1; i <= num; i++)
            {
                countZeros += num / (int)(Math.Pow(5, i));
            }

            Console.WriteLine("In {0} Factorial zeros is: {1}", num, countZeros);
        }
    }
}
