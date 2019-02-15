using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace SqrtOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter num: ");
                int num = int.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    throw new FormatException();
                }

                double result = Math.Sqrt(num);
                Console.WriteLine("Sqrt of {0} is: {1}", num, result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
