using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Task 16

namespace HTMLDocHyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlFile = File.ReadAllText("HTMLDoc.html");
            Console.WriteLine(htmlFile + "\n");

            int ahrefIndex = htmlFile.IndexOf("<a href=\"");
            int ahrefEndIndex = htmlFile.IndexOf("\">");
            int aEndIndex = htmlFile.IndexOf("</a>");

            string ahrefReplace = "[URL=";
            string ahrefEndReplace = "] ";
            string aEndReplace = "[/URL]";

            while (ahrefIndex != -1 && ahrefEndIndex != -1 && aEndIndex != -1) 
            {
                htmlFile = htmlFile.Replace(htmlFile.Substring(ahrefIndex, 9), ahrefReplace);
                htmlFile = htmlFile.Replace(htmlFile.Substring(ahrefEndIndex - 4, 2), ahrefEndReplace);
                htmlFile = htmlFile.Replace(htmlFile.Substring(aEndIndex - 4, 4), aEndReplace);

                ahrefIndex = htmlFile.IndexOf("<a href=\"", ahrefIndex + 9);
                ahrefEndIndex = htmlFile.IndexOf("\">", ahrefEndIndex + 2);
                aEndIndex = htmlFile.IndexOf("</a>", aEndIndex + 4);
            }

            Console.WriteLine(htmlFile + "\n");
        }
    }
}
