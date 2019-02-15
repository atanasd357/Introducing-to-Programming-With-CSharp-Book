using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 14

namespace Sum_Many_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1 = 0.000001F;
            float sumFloat = 0F;

            for (int i = 0; i < 50000000; i++)
            {
                sumFloat += n1;
            }
            
            double n2 = 0.000001;
            double sumDouble = 0;

            for (int i = 0; i < 50000000; i++)
            {
                sumDouble += n2;
            }
            
            decimal n3 = 0.000001M;
            decimal sumDecimal = 0M;

            for (int i = 0; i < 50000000; i++)
            {
                sumDecimal += n3;
            }

            Console.WriteLine("Sum with float type: {0}", sumFloat);
            Console.WriteLine("Sum with double type: {0}", sumDouble);
            Console.WriteLine("Sum with decimal type: {0}", sumDecimal);
        }
    }
}
