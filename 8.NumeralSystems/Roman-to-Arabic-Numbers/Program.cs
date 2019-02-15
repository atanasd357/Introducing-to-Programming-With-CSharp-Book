using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Roman_to_Arabic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter roman number: ");
            string number = Console.ReadLine().ToUpper();

            int currentNum = 0;
            int previousNum = 0;
            int resultArabNum = 0;

            foreach (char num in number)
            {
                switch(num)
                {
                    case 'I': currentNum = 1; break;
                    case 'V': currentNum = 5; break;
                    case 'X': currentNum = 10; break;
                    case 'L': currentNum = 50; break;
                    case 'C': currentNum = 100; break;
                    case 'D': currentNum = 500; break;
                    case 'M': currentNum = 1000; break;
                }

                if (currentNum > previousNum)
                {
                    currentNum -= 2 * previousNum;
                    resultArabNum += currentNum;
                }
                else
                {
                    resultArabNum += currentNum;
                }

                previousNum = currentNum;
            }

            Console.WriteLine("To arabic: {0}", Math.Abs(resultArabNum));
        }
    }
}
