using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Find_Bigger_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int biggerNum = Math.Max(num1, num2);

            Console.WriteLine("The bigger number is: {0}", biggerNum);
        }
    }
}
