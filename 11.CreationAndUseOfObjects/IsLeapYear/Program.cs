using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace IsLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine(isLeap ? ("" + year + " is leap year.") : ("" + year + " is not leap year."));
        }
    }
}
