using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Task 6

namespace IncreaseGivenLettersInText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text with upcase tags: ");
            string text = Console.ReadLine();

            string result = IncreaseLetters(text);
            Console.WriteLine(result);
        }

        static string IncreaseLetters(string text)
        {
            string result = Regex.Replace(text, @"<upcase>(.+?)</upcase>",
                match => match.Groups[1].Value.ToUpper());
            return result;
        }
    }
}
