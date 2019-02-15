using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Calculate_Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            double privateFactorial = 1;

            for (int i = K + 1; i <= N; i++)
            {
                privateFactorial *= i;
            }

            Console.WriteLine(privateFactorial);
        }
    }
}
