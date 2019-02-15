using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

//Task 3

namespace DayOfTheWeek
{
    class Program
    {
      static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            
            //Change culture to en-US
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Console.WriteLine(today.ToString("dddd"));
        }
    }
}
