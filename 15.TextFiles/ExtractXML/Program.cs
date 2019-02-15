using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 10

namespace ExtractXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFileName = "XML file.xml";

            StreamReader reader = new StreamReader(xmlFileName);
            StringBuilder strBuild = new StringBuilder();

            using (reader)
            {
                string line = reader.ReadLine();
                bool openTag = false;
                string word = null;

                while (line != null)
                {
                    foreach(char symbol in line)
                    {
                        if (symbol == '<')
                        {
                            openTag = true;
                        }
                        else if (symbol == '>')
                        {
                            openTag = false;
                        }

                        if (!openTag) 
                        {
                            if (symbol != ' ' && symbol != '>') 
                            {
                                word += symbol;
                            }
                        }

                        if (openTag && word != null)
                        {
                            strBuild.AppendLine(word);
                            word = null;
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine(strBuild);
        }
    }
}
