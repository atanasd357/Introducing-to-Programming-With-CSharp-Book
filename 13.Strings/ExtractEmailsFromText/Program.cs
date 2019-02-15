using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

//Task 19

namespace ExtractEmailsFromText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Please contact us by phone(+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. " +
                "This is not email: test @test. This also: @gmail.com.Neither this: a @a.b.";

            Console.WriteLine(text);

            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            RegexOptions.IgnoreCase);

            MatchCollection emails = emailRegex.Matches(text);

            Console.WriteLine("\nThe e-mails in the given text are:");

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();
        }
    }
}
