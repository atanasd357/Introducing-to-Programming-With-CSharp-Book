using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 9

namespace RemoveAllOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Text file.txt";

            List<string> linesList = new List<string>();
            StreamReader reader = new StreamReader(fileName);

            using (reader)
            {           
                string line = reader.ReadLine();
     
                while (line != null)
                {
                    linesList.Add(line);
                    line = reader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("UTF-8"));

            using (writer)
            {
                for (int i = 0; i < linesList.Count; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        writer.WriteLine(linesList[i]);
                    }
                }
            }
        }
    }
}
