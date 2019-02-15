using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

//Task 20

namespace DatesFromText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I was born at 14.06.1980.My sister was born at 3.7.1984.In 5 / 1999 " +
                "I graduated my high school.The law says(see section 7.3.12) that we are allowed to do this(section 7.4.2.9).";

            Console.WriteLine(text);

            Regex dataRegex = new Regex(@"\d{1,2}.\d{1,2}.\d{4}");
            MatchCollection dates = dataRegex.Matches(text);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            CultureInfo provider = CultureInfo.CurrentCulture;
     
            Console.WriteLine("\nThe dates in the given text are:");

            foreach (Match dateItem in dates)
            {
                DateTime date = DateTime.ParseExact(dateItem.ToString(), "d.M.yyyy",provider);
                Console.WriteLine("{0:d}", date);
            }
            Console.WriteLine();
        }
    }
}
