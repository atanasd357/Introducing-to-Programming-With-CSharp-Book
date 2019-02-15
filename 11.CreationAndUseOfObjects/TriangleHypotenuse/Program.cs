using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace TriangleHypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first cathetus: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second cathetus: ");
            int b = int.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The hypotenuse is: {0}", c);
        }
    }
}
