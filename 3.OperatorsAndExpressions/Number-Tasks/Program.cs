using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Number_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());

            int a = (num / 1000) % 10;
            int b = (num / 100) % 10;
            int c = (num / 10) % 10;
            int d = num % 10;

            int sumDigits = a + b + c + d;
            Console.WriteLine(sumDigits);

            int[] digits = { a, b, c, d };
            Console.WriteLine(digits[3] + "" + digits[2] + "" + digits[1] + "" + digits[0]);
           
            Console.WriteLine(d + "" + a + "" + b + "" + c);
            Console.WriteLine(a + "" + c + "" + b + "" + d);
        }
    }
}
