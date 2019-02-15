using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace FindAndPrintMajorant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 2, 4, 3, 2, 2, 2, 4, 7, 2, 2, 2, 9, 4, 2, 8, 3, 2 };
            int[] occurrencesArray = new int[numbersArray.Length];

            int majorantRequirements = (numbersArray.Length / 2) + 1;
            int majorant = 0;
            bool isMajorantFinded = false;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                occurrencesArray[numbersArray[i]]++;
            }

            for (int i = 0; i <= numbersArray.Length; i++)
            {
                if (occurrencesArray[i] == majorantRequirements)
                {
                    majorant = i;
                    isMajorantFinded = true;
                }
            }

            if (isMajorantFinded) 
            {
                Console.WriteLine("The majorant is: {0}", majorant);
            }
            else
            {
                Console.WriteLine("The majorant does not exists!");
            }
        }
    }
}
