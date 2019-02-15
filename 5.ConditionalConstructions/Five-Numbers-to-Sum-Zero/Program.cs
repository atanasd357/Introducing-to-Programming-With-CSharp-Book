using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace Five_Numbers_to_Sum_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 3: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 4: ");
            int n4 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 5: ");
            int n5 = int.Parse(Console.ReadLine());

            if (n1 + n2 == 0 || n1 + n3 == 0 || n1 + n4 == 0 || n1 + n5 == 0)
            {
                if (n1 + n2 == 0)
                {
                    Console.WriteLine("{0}, {1}", n1, n2);
                }
                if (n1 + n3 == 0)
                {
                    Console.WriteLine("{0}, {1}", n1, n3);
                }
                if (n1 + n4 == 0)
                {
                    Console.WriteLine("{0}, {1}", n1, n4);
                }
                if (n1 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}", n1, n5);
                }
            }

            if (n2 + n3 == 0 || n2 + n4 == 0 || n2 + n5 == 0)
            {
                if (n2 + n3 == 0)
                {
                    Console.WriteLine("{0}, {1}", n2, n3);
                }
                if (n2 + n4 == 0)
                {
                    Console.WriteLine("{0}, {1}", n2, n4);
                }
                if (n2 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}", n2, n5);
                }
            }

            if (n3 + n4 == 0 || n3 + n5 == 0)
            {
                if (n3 + n4 == 0)
                {
                    Console.WriteLine("{0}, {1}", n3, n4);
                }
                if (n3 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}", n3, n5);
                }
            }

            if (n4 + n5 == 0)
            {
                Console.WriteLine("{0}, {1}", n4, n5);
            }

            if (n1 + n2 + n3 == 0 || n1 + n2 + n4 == 0 || n1 + n2 + n5 == 0 ||
                n1 + n3 + n4 == 0 || n1 + n3 + n5 == 0 ||
                n1 + n4 + n5 == 0)
            {
                if (n1 + n2 + n3 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n1, n2, n3);
                }
                if (n1 + n2 + n4 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n1, n2, n4);
                }
                if (n1 + n2 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n1, n2, n5);
                }
                if (n1 + n3 + n4 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n1, n3, n4);
                }
                if (n1 + n3 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n1, n3, n5);
                }
                if (n1 + n4 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n1, n4, n5);
                }
            }

            if (n2 + n3 + n4 == 0 || n2 + n3 + n5 == 0 ||
                n2 + n4 + n5 == 0)
            {
                if (n2 + n3 + n4 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n2, n3, n4);
                }
                if (n2 + n3 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n2, n3, n5);
                }
                if (n2 + n4 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}", n2, n4, n5);
                }
            }

            if (n3 + n4 + n5 == 0)
            {
                Console.WriteLine("{0}, {1}, {2}", n3, n4, n5);
            }

            if (n1 + n2 + n3 + n4 == 0 || n1 + n2 + n3 + n5 == 0 ||
                n1 + n3 + n4 + n5 == 0)
            {
                if (n1 + n2 + n3 + n4 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", n1, n2, n3, n4);
                }
                if (n1 + n2 + n3 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", n1, n2, n3, n5);
                }
                if (n1 + n3 + n4 + n5 == 0)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", n1, n3, n4, n5);
                }
            }

            if (n2 + n3 + n4 + n5 == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", n2, n3, n4, n5);
            }

            if (n1 + n2 + n3 + n4 + n5 == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", n1, n2, n3, n4, n5);
            }
        }
    }
}
