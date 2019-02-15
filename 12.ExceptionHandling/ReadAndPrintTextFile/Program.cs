using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 9

namespace ReadAndPrintTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text file name: ");
            string textFileName = Console.ReadLine();

            ReadAndPrintText(textFileName);
        }

        static void ReadAndPrintText(string textFileName)
        {
            using (StreamReader reader = new StreamReader(textFileName))
            {
                string line;
                StringBuilder strBuild = new StringBuilder();

                while ((line = reader.ReadLine()) != null)
                {
                    strBuild.Append(line);
                    strBuild.AppendLine();
                }

                if (strBuild == null) 
                {
                    throw new FileNotFoundException();
                    throw new FormatException();
                    throw new ArgumentException();
                    throw new UnauthorizedAccessException();
                    throw new FieldAccessException();
                }
                else
                {
                    Console.WriteLine(strBuild);
                }                     
            }
        }
    }
}
