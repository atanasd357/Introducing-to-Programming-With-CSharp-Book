using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = InputDate();

            int workingDays = CalculateWorkingDays(startDate, endDate);

            Console.WriteLine("The working days between today and {0:d} is: {1}", endDate, workingDays);
        }

        static DateTime InputDate()
        {
            Console.Write("Enter data in format: yyyy.mm.dd: ");
            string inputDate = Console.ReadLine();

            char delimiter = '.';
            string[] splitString = inputDate.Split(delimiter);
            int year = int.Parse(splitString[0]);
            int month = int.Parse(splitString[1]);
            int day = int.Parse(splitString[2]);

            DateTime endDate = new DateTime(year, month, day);
            return endDate;

        }
        static int CalculateWorkingDays(DateTime startDate, DateTime endDate)
        {
            DateTime[] officialHolidays =
            {
                new DateTime(2018, 1, 1),
                new DateTime(2018, 3, 5),
                new DateTime(2018, 4, 6),
                new DateTime(2018, 4, 9),
                new DateTime(2018, 5, 1),
                new DateTime(2018, 5, 7),
                new DateTime(2018, 5, 24),
                new DateTime(2018, 9, 6),
                new DateTime(2018, 9, 24),
                new DateTime(2018, 12, 24),
                new DateTime(2018, 12, 25),
                new DateTime(2018, 12, 26),
                new DateTime(2018, 12, 31)
            };

            int workingDays = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                bool isWorkDay = true;
                for (int j = 0; j < officialHolidays.Length; j++)
                {
                    if (officialHolidays[j] == i)
                    {
                        isWorkDay = false;
                        break;
                    }
                }

                if (isWorkDay && (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday))
                {
                    isWorkDay = false;
                }
                
                if (isWorkDay)
                {
                    workingDays++;
                }
            }

            return workingDays;
        }
    }
}
