using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string text = Console.ReadLine();
            Console.Write("Enter a six-letter cipher: ");
            string cipher = Console.ReadLine();

            int index = 0;

            foreach (char letter in text)
            {
                ushort cipherLetterCode = cipher[index % cipher.Length]; 
                int  resultCharCode = letter ^ cipherLetterCode;
                Console.Write("\\u{0:x4}", resultCharCode);
                index++;
            }
            Console.WriteLine();
        }
    }
}
