using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = 2;
            int b2 = 5;
            int h = 3;
            double trapezoidArea = ((b1 + b2) / 2) * h;
            Console.WriteLine(trapezoidArea);
        }
    }
}
