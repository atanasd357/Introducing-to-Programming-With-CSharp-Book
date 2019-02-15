using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int firstNum = 0;
            int secondNum = 1;
            int sumNum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(firstNum);
                sumNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sumNum;
            }
        }
    }
}
