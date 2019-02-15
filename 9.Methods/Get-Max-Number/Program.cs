using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace GetMaxNumber
{
    class GetMaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int biggestNum = Math.Max(n3, GetMaxNum(n1, n2));
            Console.WriteLine("The biggest number is: {0}", biggestNum);
        }

        static int GetMaxNum(int n1, int n2)
        {
            return Math.Max(n1, n2);
        }
    }
}
