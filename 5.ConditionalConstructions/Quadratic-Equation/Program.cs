using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant == 0)
            {
                Console.WriteLine("The equation has only one real radical.");
                double x = -(b / (2 * a));
                Console.WriteLine("x= {0}", x);
            }
            else if (discriminant > 0)
            {
                Console.WriteLine("The equation have two real radicals.");
                double x1 = (-(b) + (Math.Sqrt(discriminant))) / (2 * a);
                double x2 = (-(b) - (Math.Sqrt(discriminant))) / (2 * a);
                Console.WriteLine("x1= {0}\n" + "x2= {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("The equation doesn't have real radicals.");
            }
        }
    }
}
