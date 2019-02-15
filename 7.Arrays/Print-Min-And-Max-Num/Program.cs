using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Print_Min_And_Max_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of nums: ");
            int n = int.Parse(Console.ReadLine());

            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

            Console.WriteLine("Enter nums:");

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
                else if (num < minNum)
                {
                    minNum = num;
                }
            }

            Console.WriteLine("Max num is: {0}", maxNum);
            Console.WriteLine("Min num is: {0}", minNum);
        }
    }
}
