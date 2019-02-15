using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

//Task 15

namespace MakingDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsAndDescr = ".NET – platform for applications from Microsoft \n" +
                "CLR – managed execution environment for .NET \n" +
                "namespace – hierarchical organization of classes";

            string[] splitByLines = Regex.Split(wordsAndDescr, "\r\n|\r|\n");

            Dictionary<string, string> dict = new Dictionary<string, string>();
            
            foreach (string strMember in splitByLines)
            {
                string[] arrayForDictionary = strMember.Split('–');
                dict.Add(arrayForDictionary[0].Trim(), arrayForDictionary[1].Trim());
            }

            Console.Write("Enter key word: ");
            string keyWord = Console.ReadLine();

            Console.WriteLine("{0} - {1}", keyWord, dict[keyWord]);  
        }
    }
}
