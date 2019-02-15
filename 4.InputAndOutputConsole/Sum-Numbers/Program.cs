using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 3: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2 + num3);
        }
    }
}
