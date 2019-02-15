using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Task 14

namespace ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter sentence: ");
            //string sentence = Console.ReadLine();

            string sentence = "C# is not C++ and PHP is not Delphi!";

            char[] charSplitters = { ' ', ',', '.', '!', '?', ':', ';' };
            string[] sentenceWords = sentence.Split(charSplitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(sentenceWords);

            string punctuationPattern = @"[\s\.!?,;:]+";
            MatchCollection punctuation = Regex.Matches(sentence, punctuationPattern);

            StringBuilder reversedSentence = new StringBuilder();

            for (int i = 0; i < sentenceWords.Length; i++)
            {
                reversedSentence.Append(sentenceWords[i]);
                reversedSentence.Append(punctuation[i]);
            }

            Console.WriteLine(reversedSentence.ToString());
        }
    }
}
