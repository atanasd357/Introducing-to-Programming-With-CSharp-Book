using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 2

namespace MergeTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFileName = "text file 1.txt";
            string secondFileName = "text file 2.txt";
            string mergedFileName = "merged text files.txt";

            try
            {
                StreamReader reader = new StreamReader(firstFileName, Encoding.GetEncoding("UTF-8"));
                StreamWriter writer = new StreamWriter(mergedFileName, false, Encoding.GetEncoding("UTF-8"));

                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    }
                }

                reader = new StreamReader(secondFileName, Encoding.GetEncoding("UTF-8"));
                writer = new StreamWriter(mergedFileName, true, Encoding.GetEncoding("UTF-8"));

                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    }
                }

                //print file with the merged text files
                Console.WriteLine("Merged text file content:");
                reader = new StreamReader(mergedFileName, Encoding.GetEncoding("UTF-8"));

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
                Console.WriteLine("The file can not been opened.");
            }
        }
    }
}
