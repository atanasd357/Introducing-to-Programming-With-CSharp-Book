using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace FindLongestSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = EnterNumbers();

            numsList.Sort();

            List<int> longestSequence = FindLongestSequence(numsList);

            Console.WriteLine("Longest sequence of equal numbers is:");
            foreach(int num in longestSequence)
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

        private static List<int> FindLongestSequence(List<int> numsList)
        {
            int currentNum = numsList[0];
            int currentSequenceLenght = 1;
            int longestSequenceLenght = 1;
            int longestSequenceStartIndex = 0;
            List<int> longestSequence = new List<int>();

            for (int i = 1; i < numsList.Count; i++)
            {
                if (numsList[i] == currentNum)
                {
                    currentSequenceLenght++;
                    if (currentSequenceLenght > longestSequenceLenght)
                    {
                        longestSequenceStartIndex = i - longestSequenceLenght;
                        longestSequenceLenght = currentSequenceLenght;                       
                    }
                }
                else
                {
                    currentNum = numsList[i];
                    currentSequenceLenght = 1;                  
                }
            }

            for (int i = 0; i < longestSequenceLenght; i++)
            {
                longestSequence.Add(numsList[longestSequenceStartIndex + i]);
            }

            return longestSequence;
        }
    }
}
