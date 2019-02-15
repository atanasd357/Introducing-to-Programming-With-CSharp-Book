using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Task 26

namespace ExtractTextFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlText = File.ReadAllText("Example.html");

            StringBuilder result = new StringBuilder();

            bool isOpen = true;
            foreach(char symbol in htmlText)
            {
                if (symbol == '<')
                {
                    isOpen = true;
                }

                if (!isOpen ) 
                {
                    result.Append(symbol);
                }
             
                if (symbol == '>')
                {
                    isOpen = false;
                }
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
