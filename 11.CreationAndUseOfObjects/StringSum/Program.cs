using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace StringSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sequence of numbers: ");
            string nums = Console.ReadLine();

            char delimiter = ' ';
            string[] splitString = nums.Split(delimiter);
            int[] numsArray = new int[splitString.Length];
            int result = 0;

            for (int i = 0; i < splitString.Length; i++)
            {
                numsArray[i] = int.Parse(splitString[i]);
                result += numsArray[i];
            }

            Console.WriteLine("The sum of the given sequence is: {0}", result);
        }
    }
}
