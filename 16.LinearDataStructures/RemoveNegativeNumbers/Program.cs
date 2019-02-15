using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 5, 19, -3, 68, -30, -154, -2, 487, 45, 63, -77, 11, -21, 26, 198 };

            List<int> positiveNums = new List<int>();

            foreach(int num in numsArray)
            {
                if (num >= 0)
                {
                    positiveNums.Add(num);
                }
            }

            foreach(int num in positiveNums)
            {
                Console.Write(num + " ");
            }
        }
    }
}
