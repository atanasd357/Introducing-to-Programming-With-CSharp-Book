using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace Point_Inside_Circle_Outside_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());

            bool isInsideAndOutside = (((x * x) + (y * y)) <= 25) &&
                ((x < -1 || x > 5) && (y < 1 || y > 55));

            Console.WriteLine(isInsideAndOutside);
        }
    }
}
