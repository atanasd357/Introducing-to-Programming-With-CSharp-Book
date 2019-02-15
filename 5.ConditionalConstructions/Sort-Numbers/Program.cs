using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter num 3: ");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1);
                    if (num3 > num2)
                    {
                        Console.WriteLine(num3);
                        Console.WriteLine(num2);
                    }
                    else
                    {
                        Console.WriteLine(num2);
                        Console.WriteLine(num3);
                    }
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2);
                    if (num3 > num1)
                    {
                        Console.WriteLine(num3);
                        Console.WriteLine(num1);
                    }
                    else
                    {
                        Console.WriteLine(num1);
                        Console.WriteLine(num3);
                    }
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
            }
        }
    }
}
