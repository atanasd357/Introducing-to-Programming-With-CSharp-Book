using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 4

namespace CompareLineByLineTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFileName = "first text file.txt";
            string secondFileName = "second text file.txt";
     
            try
            {
                StreamReader firstFileReader = new StreamReader(firstFileName, Encoding.GetEncoding("UTF-8"));
                StreamReader secondFileReader = new StreamReader(secondFileName, Encoding.GetEncoding("UTF-8"));

                using (firstFileReader)
                {
                    using (secondFileReader)
                    {
                        string firstFileLine = firstFileReader.ReadLine();
                        string secondFileLine = secondFileReader.ReadLine();
                        int coincidentalRowsNumber = 0;
                        int differentRowsNumber = 0;

                        while (firstFileLine != null && secondFileLine != null)
                        {
                            if (firstFileLine == secondFileLine)
                            {
                                coincidentalRowsNumber++;
                            }
                            else
                            {
                                differentRowsNumber++;
                            }

                            firstFileLine = firstFileReader.ReadLine();
                            secondFileLine = secondFileReader.ReadLine();
                        }

                        if (firstFileLine != null || secondFileLine != null)
                        {
                            throw new Exception("The files do not contain the equal number of rows.");
                        }
                        else
                        {
                            Console.WriteLine("The number of coincidental rows is: {0}", coincidentalRowsNumber);
                            Console.WriteLine("The number of different rows is: {0}", differentRowsNumber);
                        }
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }
    }
}
