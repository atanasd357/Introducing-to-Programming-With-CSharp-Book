using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace CorrectPlacedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression: ");
            string expression = Console.ReadLine();

            int bracketsCound = IsBracketsCorrect(expression);

            if (bracketsCound == 0)
            {
                Console.WriteLine("The brackets are correctly placed!");
            }
            else
            {
                Console.WriteLine("The brackets are incorrectly placed!");
            }
        }

        static int IsBracketsCorrect(string expression)
        {
            int bracketsCount = 0;

            foreach (char symbol in expression)
            {
                if (symbol == '(')
                {
                    bracketsCount++;
                }
                else if (symbol == ')') 
                {
                    bracketsCount--;
                }
            }

            return bracketsCount;
        }
    }
}
