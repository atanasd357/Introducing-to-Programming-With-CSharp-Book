using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            int multiplier = 0;

            switch (score)
            {
                case 1:
                case 2:
                case 3: multiplier = 10; break;
                case 4:
                case 5:
                case 6: multiplier = 100; break;
                case 7:
                case 8:
                case 9: multiplier = 1000; break;
                default: Console.WriteLine("The score must be between 1 and 9"); break;
            }

            Console.WriteLine(score*multiplier);
        }
    }
}
