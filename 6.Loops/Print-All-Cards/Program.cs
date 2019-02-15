using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace Print_All_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int color = 1; color <= 4; color++)
            {
                for (int card = 2; card <= 14; card++)
                {
                    Console.Write(card + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
