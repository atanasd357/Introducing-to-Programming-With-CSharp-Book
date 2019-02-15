using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace Hexadecimal_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal num: ");
            string number = Console.ReadLine().ToUpper();

            double resultDecNum = 0;
            int count = number.Length;

            foreach (char num in number)
            {
                count--;
                if (num == 'A' || num == 'B' || num == 'C' || num == 'D' ||
                    num == 'E' || num == 'F')
                {
                    switch (num)
                    {
                        case 'A': resultDecNum += 10 * (Math.Pow(16, count)); break;
                        case 'B': resultDecNum += 11 * (Math.Pow(16, count)); break;
                        case 'C': resultDecNum += 12 * (Math.Pow(16, count)); break;
                        case 'D': resultDecNum += 13 * (Math.Pow(16, count)); break;
                        case 'E': resultDecNum += 14 * (Math.Pow(16, count)); break;
                        case 'F': resultDecNum += 15 * (Math.Pow(16, count)); break;
                    }
                }
                else
                {
                    resultDecNum += ((int)num - 48) * (Math.Pow(16, count));
                }
            }

            Console.WriteLine("To decimal = " + resultDecNum);
        }
    }
}
