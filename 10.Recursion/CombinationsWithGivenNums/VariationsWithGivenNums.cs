using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariationsWithGivenNums
{
    class VariationsWithGivenNums
    {
        //exercise 3
        static void Main(string[] args)
        {
            Console.Write("Enter a number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the class: ");
            int k = int.Parse(Console.ReadLine());

            int[] loops = new int[k];
            MakeVariations(0, k, loops, n);
        }

        static void MakeVariations(int currentLoop, int k, int[] loops, int n)
        {
            if (currentLoop == k)
            {
                PrintLoops(k, loops);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                loops[currentLoop] = i;
                MakeVariations(currentLoop + 1, k, loops,n);
            }
        }

        static void PrintLoops(int k, int[] loops)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
