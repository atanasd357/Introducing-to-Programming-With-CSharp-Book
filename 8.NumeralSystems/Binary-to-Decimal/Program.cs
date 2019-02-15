using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            long num = long.Parse(Console.ReadLine());

            double resultNumDec = 0;
            int count = 0;

            while (num > 0)
            {
                resultNumDec += (num % 10) * (Math.Pow(2, count));
                num /= 10;
                count++;
            }

            Console.WriteLine("To decimal: {0}", resultNumDec);
        }
    }
}
