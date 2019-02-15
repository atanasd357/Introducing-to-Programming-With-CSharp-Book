using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace PrintSentencesWithACertainWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            Console.Write("Enter some word: ");
            string word = Console.ReadLine();

            string[] sepSentences = text.Split('.');

            for (int i = 0; i < sepSentences.Length; i++)
            {
                int wordIndex = sepSentences[i].IndexOf(word);

                while (wordIndex != -1)
                {
                    bool isLetterBefore = Char.IsLetter(sepSentences[i], wordIndex - 1);
                    bool isLetterAfter = Char.IsLetter(sepSentences[i] + '.', wordIndex + word.Length);
                    if (isLetterBefore == false && isLetterAfter == false)
                    {
                        Console.WriteLine("{0}.", sepSentences[i].TrimStart());
                    }
                    wordIndex = sepSentences[i].IndexOf(word, wordIndex + word.Length);
                }          
            }
        }
    }
}
