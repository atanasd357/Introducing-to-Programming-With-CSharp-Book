using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

//Task 13

namespace DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a web address from which want to download file: ");
            string filePath = Console.ReadLine();
            Console.WriteLine("Enter a name of the file at your system: ");
            string fileName = Console.ReadLine();

            WebClient webCl = new WebClient();

            try
            {
                webCl.DownloadFile(filePath, fileName);
                Console.WriteLine("The download was successsful!");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Invalid argument!");
            }

            catch (WebException)
            {
                Console.WriteLine("Invalid web adress or not existing file!");
            }

            catch (NotSupportedException notSup)
            {
                Console.WriteLine(notSup.Message);
            }

            finally
            {
                webCl.Dispose();
            }
        }
    }
}
