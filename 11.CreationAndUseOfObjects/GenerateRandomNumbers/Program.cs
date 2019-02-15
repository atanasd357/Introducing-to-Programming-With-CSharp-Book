using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace GenerateRandomNumbers
{
    class Program
    {
       static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(100, 200) + 1);
            }
        }
    }
}
