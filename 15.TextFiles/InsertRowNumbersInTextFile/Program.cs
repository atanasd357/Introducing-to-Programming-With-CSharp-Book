using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 3

namespace InsertRowNumbersInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "text file without row numbers.txt";
            string outputFile = "text file with row number.txt";

            try
            {
                StreamReader reader = new StreamReader(inputFile, Encoding.GetEncoding("UTF-8"));
                StreamWriter writer = new StreamWriter(outputFile, false, Encoding.GetEncoding("UTF-8"));

                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        int rowNumber = 0;

                        while (line != null)
                        {
                            rowNumber++;
                            writer.WriteLine(InsertRowNumbers(line, rowNumber));
                            line = reader.ReadLine();
                        }
                    }
                }
               
                //print output file content
                Console.WriteLine("Output file content:");
                reader = new StreamReader(outputFile, Encoding.GetEncoding("UTF-8"));
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("The file can not been opened");
            }
        }

        public static string InsertRowNumbers(string line, int rowNumber)
        {
            StringBuilder newLineBuilder = new StringBuilder();
            newLineBuilder.Append(rowNumber + ". " + line);
            return newLineBuilder.ToString();
        }
    }
}
