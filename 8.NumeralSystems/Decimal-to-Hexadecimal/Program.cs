using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Decimal_to_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int n = int.Parse(Console.ReadLine());

            double result = 0;
            string resultNum = "";

            while (n > 0)
            {
                result = n % 16;
                if (result >= 10)
                {
                    switch (result)
                    {
                        case 10: resultNum = "A" + resultNum; break;
                        case 11: resultNum = "B" + resultNum; break;
                        case 12: resultNum = "C" + resultNum; break;
                        case 13: resultNum = "D" + resultNum; break;
                        case 14: resultNum = "E" + resultNum; break;
                        case 15: resultNum = "F" + resultNum; break;
                    }
                }
                else
                {
                    resultNum = result + resultNum;
                }
                n /= 16;
            }

            Console.WriteLine("To hexadecimal: {0}", resultNum);
        }
    }
}
