using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace AscendingSortNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = EnterNumbers();

            numsList.Sort();

            Console.WriteLine("Sorted numbers in ascending order:");
            foreach(int num in numsList)
            {
                Console.WriteLine(num);
            }
        }

        private static List<int> EnterNumbers()
        {
            List<int> numsList = new List<int>();

            Console.WriteLine("Enter numbers:");
            while (true)
            {
                string num = Console.ReadLine();
                if (num == String.Empty)
                {
                    return numsList;
                }
                numsList.Add(int.Parse(num));
            }
        }
    }
}
