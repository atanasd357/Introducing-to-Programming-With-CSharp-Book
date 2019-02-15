using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Task 11

namespace CensorForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. " +
                "It uses advanced parser and special optimizer for the Microsoft CLR.";
            Console.WriteLine(text);
            string words = "C#,CLR,Microsoft";
            Console.WriteLine("\nForbidden words is: " + words);

            char[] splitChars = { ' ', ',' };
            string[] forbiddenWords = words.Split(splitChars);

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                int wordIndex = text.IndexOf(forbiddenWords[i].Trim());

                while (wordIndex != -1)
                {
                    string replacement = new String('*', forbiddenWords[i].Length);
                    text = text.Replace(text, Regex.Replace(text, forbiddenWords[i], replacement));

                    wordIndex = text.IndexOf(forbiddenWords[i].Trim(), 
                        wordIndex + forbiddenWords[i].Trim().Length);
                }
            }

            Console.WriteLine("\n" + text + "\n");
        }
    }
}
