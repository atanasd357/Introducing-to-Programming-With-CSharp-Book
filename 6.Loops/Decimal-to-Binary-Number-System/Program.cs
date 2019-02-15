using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Decimal_to_Binary_Number_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int resultAnswer = 0;
            string resultNum = "";

            while (n > 0)
            {
                resultAnswer = n % 2;
                resultNum = resultAnswer + resultNum;
                n /= 2;
            }

            Console.WriteLine(resultNum);
        }
    }
}
