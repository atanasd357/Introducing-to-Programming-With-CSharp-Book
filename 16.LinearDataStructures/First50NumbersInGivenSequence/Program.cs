using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace First50NumbersInGivenSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int countPrintedNumbers = 0;
            Queue<int> sequenceQueue = new Queue<int>(); 
            int s2, s3, s4 = 0;
       
            sequenceQueue.Enqueue(N);
            int currentNum = sequenceQueue.Dequeue();
            Console.WriteLine();

            while (countPrintedNumbers < 50)
            {              
                Console.WriteLine(currentNum);
                countPrintedNumbers++;

                s2 = currentNum + 1;
                sequenceQueue.Enqueue(s2);

                s3 = 2 * currentNum + 1;
                sequenceQueue.Enqueue(s3);

                s4 = currentNum + 2;       
                sequenceQueue.Enqueue(s4);

                currentNum = sequenceQueue.Dequeue();             
            }        
        }
    }
}
