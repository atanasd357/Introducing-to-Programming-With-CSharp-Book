using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace Human_In_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight on earth: ");
            int weightOnEarth = int.Parse(Console.ReadLine());

            double weightOnMoon = 0.17 * weightOnEarth;

            Console.WriteLine(weightOnMoon);
        }
    }
}
