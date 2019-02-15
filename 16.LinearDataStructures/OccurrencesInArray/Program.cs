using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace OccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] occurrencesArray = new int[1001];
            int[] numbersArray = { 2, 4, 5, 3, 2, 6, 4, 7, 1, 2, 7, 9, 4, 8, 8, 3, 11 };

            for (int i = 0; i < numbersArray.Length; i++)
            {
                occurrencesArray[numbersArray[i]]++;
            }

            for (int i = 0; i < occurrencesArray.Length; i++)
            {
                if (occurrencesArray[i] != 0)
                {
                    if (occurrencesArray[i] == 1)
                    {
                        Console.WriteLine("Number: {0} - {1} time", i, occurrencesArray[i]);
                    }
                    else
                    {
                        Console.WriteLine("Number: {0} - {1} times", i, occurrencesArray[i]);
                    }
                }
            }
        }
    }
}
