using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            int h = int.Parse(Console.ReadLine());

            int squareArea = a * h;
            int squareTour = 2 * (a + h);

            Console.WriteLine(squareArea);
            Console.WriteLine(squareTour);
        }
    }
}
