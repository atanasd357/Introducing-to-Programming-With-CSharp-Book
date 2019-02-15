using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace Sum_Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumNumbers = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number: ");
                string number = Console.ReadLine();

                int num;
                bool tryParse = int.TryParse(number, out num);

                while (tryParse != true)
                {
                    Console.Write("Invalid input, try again: ");
                    number = Console.ReadLine();
                    tryParse = int.TryParse(number, out num);
                }

                sumNumbers += num;
            }

            Console.WriteLine(sumNumbers);
        }
    }
}
