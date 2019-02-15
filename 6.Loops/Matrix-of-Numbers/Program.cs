using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = rows+1; cols <= rows+n; cols++)
                {
                    Console.Write(cols);
                }

                Console.WriteLine();
            }
        }
    }
}
