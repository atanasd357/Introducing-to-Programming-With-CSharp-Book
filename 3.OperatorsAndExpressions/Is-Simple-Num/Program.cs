using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 14

namespace Is_Prime_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (n == 1)
            {
                isPrime = false;
            }

            if (n == 2)
            {
                isPrime = true;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
