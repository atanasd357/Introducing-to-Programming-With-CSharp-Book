using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Task 18

namespace DateAndTimeParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 dates in format: day.month.year hours:minutes:seconds:");
            string inputDateAndTime = Console.ReadLine();
           
            string format = "dd.MM.yyyy HH:mm:ss";
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime startDateAndTime = DateTime.ParseExact(inputDateAndTime, format, provider);

            startDateAndTime = startDateAndTime.AddHours(6).AddMinutes(30);

            Console.WriteLine("\nThe date and time after 6 hours and 30 minutes will be: \n{0}\n",
                startDateAndTime.ToString("dd.MM.yyyy HH:mm:ss"));
        }
    }
}
