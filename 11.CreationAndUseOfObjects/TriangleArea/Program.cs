using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side c= ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter height ha= ");
            double ha = double.Parse(Console.ReadLine());
            Console.Write("Enter angle between a and b in degrees= ");
            double gamaDeg = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The area at given three sides a={0}, b={1}, c={2} is: {3}\n", 
                a, b, c, ThreeSides(a, b, c));
            Console.WriteLine("The area at given side a={0} and height ha={1} is: {2}\n", 
                a, ha, SideAndHeight(a, ha));
            Console.WriteLine("The area at given two sides a={0}, b={1} and {2} degrees angle between sides is: {3}\n",
                a, b, gamaDeg, SidesAndAngle(a, b, gamaDeg));
        }

        static double ThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static double SideAndHeight(double a, double ha)
        {
            double area = (a * ha) / 2;
            return area;
        }

        static double SidesAndAngle(double a, double b, double gamaDeg)
        {
            double gamaRad = (gamaDeg * Math.PI) / 180;
            double area = (a * b * Math.Sin(gamaRad)) / 2;
            return area;
        }
    }
}
