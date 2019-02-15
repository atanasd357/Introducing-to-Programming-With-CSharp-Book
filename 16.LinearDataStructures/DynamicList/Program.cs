using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11, 15
namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList dynamicList = new DoubleLinkedList();
            dynamicList.Add(5);
            dynamicList.Add(10);
            dynamicList.Add(15);
            dynamicList.Add(20);

            Console.WriteLine(dynamicList.Count);
            Console.WriteLine(dynamicList[1]);
            dynamicList[1] = 140;
            Console.WriteLine(dynamicList[1]);

            for (int i = 0; i < dynamicList.Count; i++)
            {
                Console.WriteLine(dynamicList[i]);
            }
            Console.WriteLine();

            dynamicList.Remove(140);
            for (int i = 0; i < dynamicList.Count; i++)
            {
                Console.WriteLine(dynamicList[i]);
            }
            Console.WriteLine();

            dynamicList.Add(1543);
            dynamicList.Add(201);
            for (int i = 0; i < dynamicList.Count; i++)
            {
                Console.WriteLine(dynamicList[i]);
            }
            Console.WriteLine();

            dynamicList.RemoveAt(3);
            for (int i = 0; i < dynamicList.Count; i++)
            {
                Console.WriteLine(dynamicList[i]);
            }
            Console.WriteLine();

            Console.WriteLine(dynamicList.IndexOf(201));

            Console.WriteLine(dynamicList.Contains(1543));
            Console.WriteLine(dynamicList.Contains(5));

            dynamicList.InsertAt(1, 77229);
            dynamicList.InsertAt(2, 75);
            dynamicList.InsertAt(3, 71);

            object[] array = dynamicList.ToArray();

            Console.WriteLine("\nPrint array elements:");
            foreach (object element in array) 
            {
                Console.WriteLine(element);
            }

            dynamicList.Add(569);
            dynamicList.Add(1000);
            Console.WriteLine("\nThe dynamic list elements before sort:");
            for (int i = 0; i < dynamicList.Count; i++)
            {
                Console.WriteLine(dynamicList[i]);
            }
            Console.WriteLine();

            dynamicList.Sort();
            Console.WriteLine("\nThe dynamic list elements after sort:");
            for (int i = 0; i < dynamicList.Count; i++)
            {
                Console.WriteLine(dynamicList[i]);
            }
            Console.WriteLine();
        }
    }
}
