using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 21

namespace ExtractPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "A palindrome is a word, phrase, number, or other sequence of " +
                "characters which reads the same backward as forward, such as madam or racecar. " +
                "The most familiar palindromes in English are character-unit palindromes. " +
                "The characters read the same backward as forward. Some examples of palindromic words are " +
                "redivider, noon, civic, radar, level, rotor, kayak and refer.";

            Console.WriteLine(text);

            char[] charSplitters = { ' ', ',', '.', '!', '?', ':', ';' };
            string[] textWords = text.Split(charSplitters, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nThe palindrome words in the given text is:");
            foreach(string word in textWords)
            {
                if (word.Length > 1)
                {
                    string tempWord = word;
                    char[] tempWordReverse = word.ToCharArray();
                    string reversedWord = null;

                    for (int i = tempWordReverse.Length - 1; i >= 0; i--)
                    {
                        reversedWord += tempWordReverse[i];
                    }

                    if (word == reversedWord)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
