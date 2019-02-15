using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace NumReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());

            ReverseNum(num);
        }

        static void ReverseNum(int num)
        {
            while (num != 0)
            {
                Console.Write(num % 10);
                num /= 10;
            }
            Console.WriteLine();
        }
    }
}
