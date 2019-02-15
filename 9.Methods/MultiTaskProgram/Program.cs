using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace MultiTaskProgram
{   
    class Program
    {
        static void Main(string[] args)
        {
            int taskNum = ChooseTask();

            if (taskNum == 1)
            {
                string result = ReverseNumDigits();
                Console.WriteLine("The inverted numbers is: {0}", result);
            }
            else if (taskNum == 2)
            {
                double resultNum = FindAverageNum();
                Console.WriteLine("The average num in the given sequence is: {0:f2}", resultNum);
            }
            else if (taskNum == 3)
            {
                double resultX = SolveEquation();
                Console.WriteLine("x= {0}", resultX);
            }
        }

        static int ChooseTask()
        {
            Console.WriteLine("Choose task:");
            Console.WriteLine("Invert a digits of number - press \"1\"");
            Console.WriteLine("Find an average number - press \"2\"");
            Console.WriteLine("Solve a linear equation \"a * x + b = 0\" - press\"3\"");
            byte taskNum = byte.Parse(Console.ReadLine());

            return taskNum;
        }

        static int ReverseNumInput()
        {
            Console.Write("Enter number for inverting: ");
            int numReverse = int.Parse(Console.ReadLine());

            if (numReverse < 0)
            {
                Console.WriteLine("Invalid number!");
            }

            return numReverse;
        }

        static string ReverseNumDigits()
        {
            int numReverse = ReverseNumInput();
            string result = "";
            int tempNum = 0;

            while (numReverse > 0)
            {
                tempNum = numReverse % 10;
                result += tempNum;
                numReverse /= 10;
            }

            return result;
        }

        static int[] FindAverageInput()
        {
            Console.Write("Enter the sequence length: ");
            int seqLength = int.Parse(Console.ReadLine());

            if (seqLength <= 0)
            {
                Console.WriteLine("Invalid sequence lenght!");
            }

            int[] arrayNums = new int[seqLength];

            Console.WriteLine("Enter sequence elements: ");
            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = int.Parse(Console.ReadLine());
            }

            return arrayNums;
        }

        static double FindAverageNum()
        {
            int[] arrayNums = FindAverageInput();
            int sum = 0;
            double resultNum = 0;

            for (int i = 0; i < arrayNums.Length; i++)
            {
                sum += arrayNums[i];
            }

            resultNum = (double)sum / arrayNums.Length;

            return resultNum;
        }

        static double SolveEquation()
        {
            Console.Write("Enter a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b= ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("The \"a\" should not be zero!");
            }

            double resultX = 0;
            resultX = -((double)b / a);

            return resultX;
        }
    }
}
