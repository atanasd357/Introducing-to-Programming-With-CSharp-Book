using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Sum_Numbers_From_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of nums: ");
            int n = int.Parse(Console.ReadLine());

            double sumNumbers = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter num {0}: ", i);
                double num = double.Parse(Console.ReadLine());

                sumNumbers += num;
            }

            Console.WriteLine("The sum is: {0}", sumNumbers);
        }
    }
}
