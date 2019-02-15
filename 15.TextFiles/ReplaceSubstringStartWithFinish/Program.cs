using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 7

namespace ReplaceSubstringStartWithFinish
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = "Text with start.txt";
            string outputFileName = "Text with finish.txt";

            StreamReader reader = new StreamReader(inputFileName);
            StreamWriter writer = new StreamWriter(outputFileName, false, Encoding.GetEncoding("UTF-8"));

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int startIndex = line.IndexOf("start");

                        while (startIndex != -1)
                        {
                            line = line.Replace(line.Substring(startIndex, 5), "finish");
                            startIndex = line.IndexOf("start", startIndex + 1);
                        }

                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
