using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace Sum_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ////first variant
            //Console.Write("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter x: ");
            //int x = int.Parse(Console.ReadLine());
           
            //double sum = 1;
            //double power = 0;
            //double factorialNum = 1;
            //
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int factorial = 1; factorial <= i; factorial++)
            //    {
            //        factorialNum *= factorial;
            //        power = Math.Pow(x, factorial);
            //    }
            //
            //    sum += (factorialNum / power);
            //    factorialNum = 1;
            //}
            //
            //Console.WriteLine(sum);

            //second simpler variant
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            double power = 1;
            double factorialNum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialNum *= i;
                power *= x;
                sum += (factorialNum / power);
            }

            Console.WriteLine(sum);
        }
    }
}
