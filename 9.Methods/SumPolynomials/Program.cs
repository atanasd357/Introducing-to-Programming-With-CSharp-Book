using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace SumPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polynomials data!");
            Console.WriteLine("Enter first polynomial: ");
            int[] firstPol = EnterData();
            Console.WriteLine("Enter second polynomial: ");
            int[] secondPol = EnterData();

            int[] sumArray = SumPolynomials(firstPol, secondPol);

            PrintResult(sumArray);           
        }

        static int[] EnterData()
        {
            int[] polArray = new int[3];
            Console.Write("x^2 = ");
            int x2 = int.Parse(Console.ReadLine());

            if (x2 != 0)
            {
                polArray[0] = x2;
            }

            Console.Write("x^1 = ");
            int x1 = int.Parse(Console.ReadLine());

            if (x1 != 0)
            {
                polArray[1] = x1;
            }

            Console.Write("x^0 = ");
            int x0 = int.Parse(Console.ReadLine());

            if (x0 != 0)
            {
                polArray[2] = x0;
            }
            Console.WriteLine();

            Array.Reverse(polArray);

            return polArray;
        }

        static int[] SumPolynomials(int[] firstPol, int[] secondPol)
        {
            int[] sumArray = new int[3];

            for (int i = 0; i < firstPol.Length; i++)
            {
                sumArray[i] = firstPol[i] + secondPol[i];
            }

            return sumArray;
        }

        static void PrintResult(int[] sumArray)
        {
            for (int i = sumArray.Length - 1; i >= 0; i--)
            {
                if (sumArray[i] != 0 && i == sumArray.Length - 1)
                {
                    Console.Write("{0}x^2 ", sumArray[i]);
                }
                else if (sumArray[i] != 0 && i == sumArray.Length - 2)
                {
                    if (sumArray[i] > 0)
                    {
                        Console.Write("+ {0}x ", sumArray[i]);
                    }
                    else
                    {
                        Console.Write("- {0}x ", sumArray[i]);
                    }
                }
                else if (sumArray[i] != 0)
                {
                    if (sumArray[i] > 0)
                    {
                        Console.Write("+ {0}", sumArray[i]);
                    }
                    else
                    {
                        Console.Write("- {0}", sumArray[i]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
