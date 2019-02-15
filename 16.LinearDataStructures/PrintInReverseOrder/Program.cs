using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace PrintInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackNums = EnterNumbers();

            Console.WriteLine("Nums in reverse order:");
            foreach (int num in stackNums)
            {
                Console.WriteLine(num);
            }
        }

        private static Stack<int> EnterNumbers()
        {
            Stack<int> stackNums = new Stack<int>();

            Console.Write("Enter number of numbers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter nums:");
            for (int i = 0; i < n; i++)
            {
                stackNums.Push(int.Parse(Console.ReadLine()));
            }

            return stackNums;
        }
    }
}
