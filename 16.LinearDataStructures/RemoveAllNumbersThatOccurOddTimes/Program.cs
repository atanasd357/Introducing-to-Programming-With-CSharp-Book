using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace RemoveAllNumbersThatOccurOddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();

            foreach(int num in numsArray)
            {
                if (numsDictionary.ContainsKey(num) == false)
                {
                    numsDictionary.Add(num, 1);
                }
                else
                {
                    numsDictionary[num]++;
                }
            }

            List<int> resultList = new List<int>();

            foreach(int num in numsArray)
            {
                if (numsDictionary[num] % 2 == 0)
                {
                    resultList.Add(num);
                }
            }

            Console.WriteLine("The list without numbers that occur odd times: ");
            foreach(int num in resultList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
