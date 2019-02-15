using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Binary_to_Decimal_and_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 1111010110011110;
            double resultNumDec = 0;
            int count = 0;

            while (num > 0)
            {
                resultNumDec += (num % 10) * (Math.Pow(2, count));
                num /= 10;
                count++;
            }

            Console.WriteLine("To decimal: {0}", resultNumDec);

            int n = (int)resultNumDec;
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
