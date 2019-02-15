using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 11

namespace FileParse
{
    class FileParse
    {
        static void Main(string[] args)
        {
            string fileName = "TextFile.txt";

            try
            {
                ParseNumbersFromFile(fileName);
            }

            catch (FileParseException fileParseEx)
            {
                Console.WriteLine(fileParseEx.Message);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("The file {0} does not exist!", fileName);
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found!");
            }

            catch (NotSupportedException notSupEx)
            {
                Console.WriteLine(notSupEx.Message);
            }
        }

        static void ParseNumbersFromFile(string fileName)
        {
            int row = 0;

            try
            {          
                using (StreamReader reader = new StreamReader(fileName))
                {
                    
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        row++;
                        int numbersInFile = int.Parse(line);
                        Console.WriteLine(numbersInFile);                
                    }
                }
            }

            catch (FormatException)
            {
                throw new FileParseException(fileName, row);
            }
        }
    }
}
