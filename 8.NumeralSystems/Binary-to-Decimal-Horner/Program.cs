using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Binary_to_Decimal_Horner
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Enter binary number: ");
            string num = Console.ReadLine();

            int decNum = ((num[0] - 48) * 2) + (num[1] - 48);

            for (int i = 1; i < num.Length - 1; i++)
            {
                decNum = decNum * 2 + (num[i + 1] - 48);
            }

            Console.WriteLine("To decimal: {0}", decNum);
        }
    }
}
