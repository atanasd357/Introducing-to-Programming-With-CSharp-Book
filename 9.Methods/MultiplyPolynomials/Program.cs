using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace MultiplyPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polynomials data!");
            Console.WriteLine("Enter first polynomial: ");
            List<int> firstPol = EnterData();
            Console.WriteLine("Enter second polynomial: ");
            List<int> secondPol = EnterData();

            int[] multiplyArray = MultiplyPolynomials(firstPol, secondPol);

            PrintResult(multiplyArray);      
        }

        static List<int> EnterData()
        {
            List<int> polList = new List<int>();
            Console.Write("x^2 = ");
            int x2 = int.Parse(Console.ReadLine());
            polList.Add(x2);
            Console.Write("x^1 = ");
            int x1 = int.Parse(Console.ReadLine());
            polList.Add(x1);
            Console.Write("x^0 = ");
            int x0 = int.Parse(Console.ReadLine());
            polList.Add(x0);
            Console.WriteLine();

            polList.Reverse();

            return polList;
        }

        static int[] MultiplyPolynomials(List<int> firstPol, List<int> secondPol)
        {
            int[] multiplyArray = new int[firstPol.Count + secondPol.Count - 1];

            for (int i = 0; i < firstPol.Count; i++)
            {
                for (int j = 0; j < secondPol.Count; j++)
                {
                    multiplyArray[i + j] += firstPol[i] * secondPol[j];
                }
            }

            return multiplyArray;
        }

        static void PrintResult(int[] multiplyArray)
        {
            for (int i = multiplyArray.Length - 1; i >= 0; i--)
            {
                if (multiplyArray[i] != 0 && i != 0)
                {
                    if (multiplyArray[i] > 0 && i < multiplyArray.Length - 1)
                    {
                        Console.Write("+ {0}x^{1} ", multiplyArray[i], i);
                    }
                    else
                    {
                        Console.Write("{0}x^{1} ", multiplyArray[i], i);
                    }
                }
                else if (multiplyArray[i] != 0 && i == 0)
                {
                    if (multiplyArray[i] > 0) 
                    {
                        Console.Write("+ {0}", multiplyArray[i]);
                    }
                    else
                    {
                        Console.Write(" {0}", multiplyArray[i]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
