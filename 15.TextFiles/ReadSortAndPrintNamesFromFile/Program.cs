using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 6

namespace ReadSortAndPrintNamesFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = "File with names.txt";

            StreamReader reader = new StreamReader(inputFileName);
            List<string> namesList = new List<string>();

            using (reader)
            {
                string name = reader.ReadLine();
                int count = 0;

                while (name != null)
                {
                    namesList.Add(name);
                    count++;
                    name = reader.ReadLine();
                }
            }

            namesList.Sort();
            StreamWriter writer = new StreamWriter("File with sorted names.txt", false, Encoding.GetEncoding("UTF-8"));

            using (writer)
            {
                foreach(string name in namesList)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}
