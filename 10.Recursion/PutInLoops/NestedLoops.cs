using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopsSimulator
{
    class NestedLoops
    {
        //exercise 1
        static void Main(string[] args)
        {
            Console.Write("Enter a number of loops: ");
            int loopsNum = int.Parse(Console.ReadLine());

            int[] loops = new int[loopsNum];
            LoopsSimulator(0, loopsNum, loops);
        }

        static void LoopsSimulator(int currentLoop, int loopsNum, int[] loops)
        {
            if (currentLoop == loopsNum)
            {
                PrintLoops(loopsNum, loops);
                return;
            }

            for (int i = 1; i <= loopsNum; i++)
            {
                loops[currentLoop] = i;
                LoopsSimulator(currentLoop + 1, loopsNum, loops);
            }
        }

        static void PrintLoops(int loopsNum, int[] loops)
        {
            for (int i = 0; i < loopsNum; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
