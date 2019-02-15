using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace Sum_Fractional_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1;
            double currentSum = 0;

            for (int i = 2; i < int.MaxValue; i++)
            {
                sum += (1d / i);
                if (sum - currentSum <= 0.001)
                {
                    Console.WriteLine(currentSum);
                    break;
                }
                currentSum = sum;
            }
        }
    }
}
