using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 23

namespace CountWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine().ToLower();

            char[] charSplitters = { ' ', ',', '.', '!', '?', ':', ';' };
            string[] textWords = text.Split(charSplitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(textWords);

            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

            foreach (string word in textWords) 
            {
                if (wordsDictionary.ContainsKey(word)) 
                {
                    wordsDictionary[word] += 1;
                }
                else
                {
                    wordsDictionary.Add(word, 1);
                }
            }

            Console.WriteLine("The words are found in the text: ");
            foreach (KeyValuePair<string,int> word in wordsDictionary)
            {
                if (word.Value == 1)
                {
                    Console.WriteLine("{0} - {1} time", word.Key, word.Value);
                }
                else
                {
                    Console.WriteLine("{0} - {1} times", word.Key, word.Value);
                }
            }
            Console.WriteLine();
        }
    }
}
