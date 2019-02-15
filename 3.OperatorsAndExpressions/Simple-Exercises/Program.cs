using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 15

namespace Change_Bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1;
            int operation1 = i << 3 ;
            int operation2 = i << 4;
            int operation3 = i << 5;
            
            //namira bitovete na pozicii 3 4 i 5
            int b3 = (n & operation1);
            int b4 = (n & operation2);
            int b5 = (n & operation3);

            Console.WriteLine(n&operation1);
            Console.WriteLine(b4);
            Console.WriteLine(b5);
            Console.WriteLine(n);
        }
    }
}
