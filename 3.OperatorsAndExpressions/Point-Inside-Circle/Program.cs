using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8 

namespace Point_Inside_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());

            bool isInside = ((x * x) + (y * y)) <= 25;

            Console.WriteLine(isInside);
        }
    }
}
