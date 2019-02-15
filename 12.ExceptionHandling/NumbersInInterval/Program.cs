using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace NumbersInInterval
{
    class Program
    {
       static void Main(string[] args)
        {
            ReadNumber(1, 100);
        }

        static void ReadNumber(int startNum, int endNum)
        {
            Console.WriteLine("Enter a 10 numbers between {0} and {1} : ", startNum, endNum);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Enter number {0}: ", i + 1);
                    int num = int.Parse(Console.ReadLine());
                    if (num <= 1 || num >= 100)
                    {
                        throw new InvalidNumberException(startNum,endNum);
                    }
                }              
            }

            catch (InvalidNumberException invalidNum)
            {
                Console.WriteLine(invalidNum.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
