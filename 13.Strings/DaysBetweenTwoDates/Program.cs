using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Task 17

namespace DaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 dates in format: day.month.year");
            Console.Write("First date: ");
            string firstDate = Console.ReadLine();
            Console.Write("Second date: ");
            string secondDate = Console.ReadLine();

            string format = "d.M.yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime startDate = DateTime.ParseExact(firstDate, format, provider);
            DateTime endDate = DateTime.ParseExact(secondDate, format, provider);

            double daysBetweenDates = Math.Abs((startDate - endDate).TotalDays);

            Console.WriteLine("Distance between this two dates is {0} days", daysBetweenDates);
        }
    }
}
