using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace Base_S_to_Base_D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            Console.Write("Enter base of the number: ");
            int baseS = int.Parse(Console.ReadLine());
            Console.Write("Enter exit base: ");
            int baseD = int.Parse(Console.ReadLine());

            if (baseS < 2 || baseD > 16)
            {
                Console.WriteLine("The base should be between 2 and 16");
            }

            int count = number.Length;
            double decimalNum = 0;

            foreach (int num in number)
            {
                count--;
                decimalNum += (num - 48) * (Math.Pow(baseS, count));
                
            }

            int resultTemp = 0;
            string resultNum = "";

            while ((int)decimalNum > 0)
            {
                resultTemp = (int)decimalNum % baseD;
                resultNum = resultTemp + resultNum;
                decimalNum /= baseD;
            }

            Console.WriteLine("To base {0}: {1}", baseD, resultNum);
        }
    }
}
