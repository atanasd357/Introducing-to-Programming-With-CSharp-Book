using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 25

namespace SortWordsAlphabetically
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words divided by comma: ");
            string enteredWords = Console.ReadLine();

            char[] splitter = { ',' };
            string[] wordsArray = enteredWords.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordsArray);

            Console.WriteLine("Sorted words:");
            foreach(string word in wordsArray)
            {
                Console.WriteLine(word.Trim());
            }
        }
    }
}
