using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace Binary_to_Decimal_Number_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            double resultNum = 0;
            int count = 0;

            while (n > 0)
            {
                resultNum += (n % 10) * (Math.Pow(2, count));
                n /= 10;
                count++;
            }

            Console.WriteLine(resultNum); 
        }
    }
}
