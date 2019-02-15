using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace DifferentOutputVariants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a num: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,15} - Decimal number", num);
            Console.WriteLine("{0,15:X} - Hexadecimal number", (int)num);
            Console.WriteLine("{0,15:P2} - Percent", num);
            Console.WriteLine("{0,15:C2} - Currency", num);
            Console.WriteLine("{0,15:E} - Scientific notation", num);        
        }
    }
}
