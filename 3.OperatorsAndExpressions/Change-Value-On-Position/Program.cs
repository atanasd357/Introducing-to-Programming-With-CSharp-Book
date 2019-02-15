using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace Change_Value_On_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter v: ");
            int v = int.Parse(Console.ReadLine());

            int i = 1;
            int operation = i << p;
            bool isTrue = (n & operation) == v;

            if (isTrue == false)
            {
                if (v == 1)
                {
                    n = n | (1 << p);
                }
                else if (v == 0)
                {
                    n = n & (~(1 << p));
                }
            }

            Console.WriteLine(n);
        }
    }
}
