using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 1

namespace PrintOddRowsFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text file with rows.txt";

            try
            {
                StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("UTF-8"));
                using (reader)
                {
                    int count = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        count++;
                        if (count % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }

            catch(FileNotFoundException)
            {
                Console.WriteLine("File with name: {0} is not found.", fileName);
            }
            catch(IOException)
            {
                Console.WriteLine("The file \"{0}\" can not been readed.", fileName);
            }
        }
    }
}
