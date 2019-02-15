using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Task 12

namespace OpenAndReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();

            try
            {
                OpenAndReadText(filePath);
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Enter valid file path!");
            }

            catch (PathTooLongException)
            {
                Console.WriteLine("The path must be less than 248 characters!");
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The path is invalid!");
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found!");
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("The path is in invalid format!");
            }

            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You don't have permission to read this file!");
            }
        }

        static void OpenAndReadText(string filePath)
        {
            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);
        }
    }
}
