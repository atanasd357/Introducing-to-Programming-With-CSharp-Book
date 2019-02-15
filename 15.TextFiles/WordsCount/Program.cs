using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Task 13

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsFileName = "words.txt";
            string textFileName = "text.txt";

            try
            {
                StreamReader wordsReader = new StreamReader(wordsFileName);
                StreamReader textReader = new StreamReader(textFileName);
                Dictionary<string, int> wordsCount = new Dictionary<string, int>();

                using (wordsReader)
                {
                    string word = wordsReader.ReadLine();

                    while (word != null)
                    {
                        wordsCount.Add(word, 0);
                        word = wordsReader.ReadLine();
                    }
                }

                using (textReader)
                {
                    string regex = @"\b[^\d\W]+\b";
                    string line = textReader.ReadLine();

                    while (line != null)
                    {
                        MatchCollection matchWords = Regex.Matches(line, regex);

                        foreach (Match word in matchWords)
                        {
                            if (wordsCount.ContainsKey(word.ToString()) == true)
                            {
                                wordsCount[word.ToString()]++;
                            }
                        }
                        line = textReader.ReadLine();
                    }
                }

                KeyValuePair<string, int>[] resultArray = wordsCount.ToArray();
                Array.Sort(resultArray, (a, b) => a.Value.CompareTo(b.Value));

                StreamWriter resultWriter = new StreamWriter("result.txt", false, Encoding.GetEncoding("UTF-8"));

                using (resultWriter)
                {
                    foreach (KeyValuePair<string, int> kvp in resultArray)
                    {
                        resultWriter.WriteLine("Word: {0}; Number of word occurrences in the text: {1}",
                            kvp.Key, kvp.Value);
                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
