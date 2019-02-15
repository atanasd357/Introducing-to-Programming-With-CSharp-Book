using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace FindSumAndAverageFromNumsList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = EnterNumbers();

            int sum = FindSum(numsList);

            double average = (double)sum / numsList.Count;

            Console.WriteLine("The sum of the entered numbers is: {0}", sum);
            Console.WriteLine("The average number is: {0}", average);
        }

        private static List<int> EnterNumbers()
        {
            List<int> numsList = new List<int>();

            Console.WriteLine("Enter numbers:");
            while(true)
            {
                string num = Console.ReadLine();
                if (num == String.Empty) 
                {
                    return numsList;
                }
                numsList.Add(int.Parse(num));
            }
        }

        private static int FindSum(List<int> numsList)
        {
            int sum = 0;
            foreach(int num in numsList)
            {
                sum += num;
            }
            return sum;
        }
    }
}
