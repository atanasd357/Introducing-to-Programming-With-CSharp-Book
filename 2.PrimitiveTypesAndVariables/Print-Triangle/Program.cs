using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Print_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '©';
            Console.WriteLine("   {0}", symbol);
            Console.WriteLine("  {0} {0}", symbol);
            Console.WriteLine(" {0}   {0}", symbol);
            Console.WriteLine("{0} {0} {0} {0}", symbol);
        }
    }
}
