using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Divide_By_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            bool b = (n % 5 == 0 && n % 7 == 0);

            Console.WriteLine(b);
        }
    }
}
