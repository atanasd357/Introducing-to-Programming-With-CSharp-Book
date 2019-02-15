using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace GivenSubstringCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine().ToLower();
            Console.Write("\nEnter substring for counting: ");
            string subStr = Console.ReadLine().ToLower();

            int subStrCount = SubstringCount(text, subStr);

            if (subStrCount != 0)
            {
                Console.WriteLine("\nThe substring \"{0}\" is met {1} times in the given text.\n", subStr, subStrCount);
            }
            else
            {
                Console.WriteLine("\nThe substring \"{0}\" is not found in the given text.", subStr);
            }
        }

        static int SubstringCount(string text, string subStr)
        {
            int subStrCount = 0;
            int index = text.IndexOf(subStr);

            if (index != -1) 
            {
                while (index != -1) 
                {
                    subStrCount++;
                    index = text.IndexOf(subStr, index + subStr.Length);
                }
                return subStrCount;
            }
            else
            {
                return subStrCount;
            }
        }
    }
}
