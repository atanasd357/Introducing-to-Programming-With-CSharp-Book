using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace ComputerWorkTime
{
    class Program
    {
      static void Main(string[] args)
        {
            //first variant
            TimeSpan timeSpans = TimeSpan.FromMilliseconds(Environment.TickCount);
            Console.WriteLine("{0:D2} days, {1:D2} hours, {2:D2} minutes", 
                timeSpans.Days,timeSpans.Hours,timeSpans.Minutes);
            Console.WriteLine();

            //second variant
            int time = Environment.TickCount;
            int minutes = time / 1000 / 60;
            int hours = minutes / 60;
            int days = hours / 24;
            Console.WriteLine("{0:D2} days, {1:D2} hours, {2:D2} minutes",
                days, hours % 24, minutes % 60);
        }
    }
}
