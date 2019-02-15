using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Check_Byte_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());

            int i = 1;
            int operation = i << p;
            bool isOne = (n & operation) == 1;

            Console.WriteLine(isOne);
        }
    }
}
