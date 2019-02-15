using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 24

namespace ReplaceConsecutiveLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string enteredStr = Console.ReadLine();

            StringBuilder resultStr = new StringBuilder();
            char previousLetter = char.MinValue;

            foreach (char letter in enteredStr)
            {
                if (letter != previousLetter)
                {
                    resultStr.Append(letter);
                }
                previousLetter = letter;
            }

            Console.WriteLine(resultStr);
        }
    }
}
