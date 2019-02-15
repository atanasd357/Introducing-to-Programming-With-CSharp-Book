using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 16

namespace One_to_N_Scrambled_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arraySort = new int[n];

            Console.Write("The array before shuffling: ");
            for (int i = 0; i < n; i++)
            {
                arraySort[i] = i + 1;
                Console.Write(arraySort[i] + " ");
            }
            Console.WriteLine();

            Random rand = new Random();
            int[] arrayShuffled = Enumerable.Range(1, n).OrderBy(c => rand.Next()).ToArray();

            Console.Write("The shuffled array: ");
            for (int i = 0; i < arrayShuffled.Length; i++)
            {
                Console.Write(arrayShuffled[i] + " ");
            }
        }         
    }
}
