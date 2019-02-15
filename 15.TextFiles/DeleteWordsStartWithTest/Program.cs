using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 11

namespace DeleteWordsStartWithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFileName = "Text file.txt";

            StreamReader reader = new StreamReader(textFileName);
            List<string> fileLines = new List<string>();

            using (reader)
            {
                string lineFromFile = reader.ReadLine();
                while (lineFromFile != null)
                {
                    fileLines.Add(lineFromFile);
                    lineFromFile = reader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter(textFileName, false, Encoding.GetEncoding("UTF-8"));
            int testIndex = 0;
            int startIndex = 0;
            int endIndex = 0;
            string wordForDelete = null;
            string line = null;

            using (writer)
            {
                for (int i = 0; i < fileLines.Count; i++)         
                {
                    line = fileLines[i];

                    testIndex = line.IndexOf("test");
                    while (testIndex != -1)
                    {
                        wordForDelete = "test";

                        startIndex = testIndex - 1;
                        if (startIndex >= 0)
                        {
                            while (Char.IsLetter(line, startIndex) == true)
                            {
                                wordForDelete = line[startIndex] + wordForDelete;
                                if (startIndex > 0)
                                {
                                    startIndex--;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                        endIndex = testIndex + 4;
                        if (endIndex < line.Length)
                        {
                            while (Char.IsLetter(line, endIndex) == true)
                            {
                                wordForDelete += line[endIndex];
                                if (endIndex < line.Length - 1) 
                                {
                                    endIndex++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                        if (wordForDelete != "test")
                        {
                            line = line.Remove(line.IndexOf(wordForDelete), wordForDelete.Length);
                            testIndex = line.IndexOf("test");
                        }
                        else
                        {
                            testIndex = line.IndexOf("test", endIndex);
                        }
                    }

                    if (!String.IsNullOrEmpty(line))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
