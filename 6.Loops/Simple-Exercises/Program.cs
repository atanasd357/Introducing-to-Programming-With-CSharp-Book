using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace Catalan_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int nTwoFactorial = 1;
            int nPlusFactorial = 1;

            for (int i = n + 1; i <= 2 * n; i++)
            {
                nTwoFactorial *= i;
            }

            for (int i = 1; i <= n + 1; i++)
            {
                nPlusFactorial *= i;
            }

            double catalanNumber = ((double)(nTwoFactorial)) / (nPlusFactorial);

            Console.WriteLine(catalanNumber);
        }
    }
}
