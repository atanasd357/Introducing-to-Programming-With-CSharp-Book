using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 15

namespace Hexadecimal_to_Decimal_Number_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string n = Console.ReadLine().ToUpper();

            double resultNum = 0;
            int count = n.Length;

            foreach (char num in n)
            {
                count--;
                if (num == 'A' || num == 'B' || num == 'C' || num == 'D' ||
                    num == 'E' || num == 'F')
                {
                    switch (num)
                    {
                        case 'A': resultNum += 10 * (Math.Pow(16, count)); break;
                        case 'B': resultNum += 11 * (Math.Pow(16, count)); break;
                        case 'C': resultNum += 12 * (Math.Pow(16, count)); break;
                        case 'D': resultNum += 13 * (Math.Pow(16, count)); break;
                        case 'E': resultNum += 14 * (Math.Pow(16, count)); break;
                        case 'F': resultNum += 15 * (Math.Pow(16, count)); break;
                    }                   
                }              
                else
                {
                    resultNum += ((int)num - 48) * (Math.Pow(16, count));
                }
            }

            Console.WriteLine(resultNum);
        }
    }
}
