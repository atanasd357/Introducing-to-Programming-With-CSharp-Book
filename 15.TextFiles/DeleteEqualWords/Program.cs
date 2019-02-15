using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Task 12

namespace DeleteEqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] wordsArray = null;
                StreamReader wordsReader = new StreamReader("words.txt");

                using (wordsReader)
                {
                    string allWords = wordsReader.ReadToEnd();
                    wordsArray = allWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                }

                StreamReader textReader = new StreamReader("text.txt");
                string text = null;

                using (textReader)
                {
                    text = textReader.ReadToEnd();
                }

                for (int i = 0; i < wordsArray.Length; i++)
                {
                    text = Regex.Replace(text, @"\b" + wordsArray[i] + @"\b",
                             String.Empty, RegexOptions.IgnoreCase);
                }

                StreamWriter textWriter = new StreamWriter("text.txt", false, Encoding.GetEncoding("UTF-8"));

                using (textWriter)
                {
                    textWriter.Write(text);
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
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
