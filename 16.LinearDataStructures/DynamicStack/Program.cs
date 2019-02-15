using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace DynamicStack
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicStack stackTest = new DynamicStack();
            stackTest.Push(8);
            stackTest.Push(34);
            stackTest.Push(56);
            stackTest.Push(111);
            stackTest.Push(12);

            Console.WriteLine("The number of elements in the stack is: {0}", stackTest.Count);
            Console.WriteLine("The top element of the stack is: {0}", stackTest.Peek());
            Console.WriteLine(stackTest.Contains(56));
            Console.WriteLine(stackTest.Contains(566));

            Console.WriteLine("Removed top element is: {0}", stackTest.Pop());
            Console.WriteLine("The top element of the stack is: {0}", stackTest.Peek());

            object[] testArray = stackTest.ToArray();

            Console.WriteLine("\nThe elements of the array:");
            foreach(object element in testArray)
            {
                Console.WriteLine(element);
            }

            stackTest.Clear();
            Console.WriteLine("\nThe number of elements in the stack is: {0}", stackTest.Count);
        }
    }
}
