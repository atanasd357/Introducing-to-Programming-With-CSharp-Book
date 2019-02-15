using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Sequence_Of_Numbers
{
    class SequenceOfNumbers
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 0; i < 100; i++)
            {
                n = 2 + i;

                if (n % 2 != 0)
                {
                    n *= -1;
                }

                Console.WriteLine(n);
            }
        }
    }
}
