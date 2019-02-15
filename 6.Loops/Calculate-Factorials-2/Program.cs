using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace Calculate_Factorials_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            int nFactorial = 1;
            int kFactorial = 1;
            int nkFactorial = 1;

            for (int i = 1; i <= N; i++)
            {
                nFactorial *= i;
            }

            for (int i = 1; i <= K; i++)
            {
                kFactorial *= i;
            }

            for (int i = 1; i <= N - K; i++)
            {
                nkFactorial *= i;
            }

            double privateFactorials = (double)(nFactorial * kFactorial) / nkFactorial;

            Console.WriteLine(privateFactorials);
        }
    }
}
