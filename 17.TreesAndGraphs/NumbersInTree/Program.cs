using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInTree
{
    class Program
    {
        //exerise 1,2,3
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(7,
                new Tree<int>(19,
                    new Tree<int>(1),
                    new Tree<int>(12),
                    new Tree<int>(31)),
                new Tree<int>(21),
                new Tree<int>(14,
                    new Tree<int>(23),
                    new Tree<int>(6,
                        new Tree<int>(12),
                        new Tree<int>(1),
                        new Tree<int>(32))),
                new Tree<int>(22,
                    new Tree<int>(21,
                        new Tree<int>(14),
                        new Tree<int>(6),
                        new Tree<int>(14),
                        new Tree<int>(1),
                        new Tree<int>(32)))
                );

            Console.WriteLine("The number of encounters at 14 is: {0}", tree.FindEncounters(14));
            Console.WriteLine("The number of encounters at 23 is: {0}", tree.FindEncounters(21));
            Console.WriteLine("The number of encounters at 1 is: {0}", tree.FindEncounters(1));
            Console.WriteLine("The number of encounters at 19 is: {0}", tree.FindEncounters(19));

            Console.WriteLine("\nThe roots with 3 peaks are:");
            tree.FindRootsWithNumberOfPeaks(3);

            Console.WriteLine("The roots with 5 peaks are:");
            tree.FindRootsWithNumberOfPeaks(5);

            Console.WriteLine("The roots with 4 peaks are:");
            tree.FindRootsWithNumberOfPeaks(4);

            tree.FindNumberOfLeafAndInnerPeaks();
            Console.WriteLine();
        }
    }
}
