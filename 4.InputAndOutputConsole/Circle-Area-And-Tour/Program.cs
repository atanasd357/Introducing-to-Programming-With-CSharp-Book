using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Circle_Area_And_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            int r = int.Parse(Console.ReadLine());

            double area = r * r * Math.PI;
            double tour = 2 * Math.PI * r;

            Console.WriteLine(area);
            Console.WriteLine(tour);
        }
    }
}
