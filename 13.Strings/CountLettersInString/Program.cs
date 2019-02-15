using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 22

namespace CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine().ToLower();

            List<char> charList = new List<char>();

            foreach (char symbol in text)
            {
                if(Char.IsLetter(symbol))
                {
                    charList.Add(symbol);
                }
            }

            charList.Sort();

            List<int> countLetters = new List<int>();
            char firstLetter = charList[0];
            int count = 0;

            foreach (char letter in charList)
            {          
                if (letter != firstLetter)
                {
                    countLetters.Add(count);
                    count = 1;
                }
                else
                {
                    count++;
                }
                firstLetter = letter;
            }
            countLetters.Add(count);

            charList = charList.Distinct().ToList();

            Console.WriteLine("The letters are found in the text: ");
            for (int i = 0; i < charList.Count; i++) 
            {
                if (countLetters[i] == 1)
                {
                    Console.WriteLine("{0} - {1} time", charList[i], countLetters[i]);
                }
                else
                {
                    Console.WriteLine("{0} - {1} times", charList[i], countLetters[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
