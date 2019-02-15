using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Print_Numbers_Not_Divide_To_3_And_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
