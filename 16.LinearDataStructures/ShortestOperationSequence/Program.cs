using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestOperationSequence
{
    class Program
    {
        //exerise 10
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            Queue<int> numbersQueue = new Queue<int>();

            numbersQueue.Enqueue(N);
            
            int currentNum = 0;
            while (true) 
            {
                currentNum = numbersQueue.Dequeue();
                if (currentNum != M)
                {
                    numbersQueue.Enqueue(currentNum + 1);
                    numbersQueue.Enqueue(currentNum + 2);
                    numbersQueue.Enqueue(currentNum * 2);
                }              
            }
        }
    }
}
