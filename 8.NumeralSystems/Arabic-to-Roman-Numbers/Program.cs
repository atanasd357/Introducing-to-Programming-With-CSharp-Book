using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Arabic_to_Roman_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arabic number: ");
            int number = int.Parse(Console.ReadLine());

            string resulRomNum = "";

            if (number > 3999 || number < 1)
            {
                Console.WriteLine("Invalid number");
            }

            if (number / 1000 != 0)
            {
                switch(number / 1000)
                {
                    case 1: resulRomNum = "M"; break;
                    case 2: resulRomNum = "MM"; break;
                    case 3: resulRomNum = "MMM"; break;
                }
            }

            if ((number / 100) % 10 != 0) 
            {
                switch((number / 100) % 10)
                {
                    case 1: resulRomNum += "C"; break;
                    case 2: resulRomNum += "CC"; break;
                    case 3: resulRomNum += "CCC"; break;
                    case 4: resulRomNum += "CD"; break;
                    case 5: resulRomNum += "D"; break;
                    case 6: resulRomNum += "DC"; break;
                    case 7: resulRomNum += "DCC"; break;
                    case 8: resulRomNum += "DCCC"; break;
                    case 9: resulRomNum += "CM"; break;
                }
            }

            if ((number / 10) % 10 != 0)
            {
                switch ((number / 10) % 10)
                {
                    case 1: resulRomNum += "X"; break;
                    case 2: resulRomNum += "XX"; break;
                    case 3: resulRomNum += "XXX"; break;
                    case 4: resulRomNum += "XL"; break;
                    case 5: resulRomNum += "L"; break;
                    case 6: resulRomNum += "LX"; break;
                    case 7: resulRomNum += "LXX"; break;
                    case 8: resulRomNum += "LXXX"; break;
                    case 9: resulRomNum += "XC"; break;
                }
            }

            if (number % 10 != 0)
            {
                switch (number % 10)
                {
                    case 1: resulRomNum += "I"; break;
                    case 2: resulRomNum += "II"; break;
                    case 3: resulRomNum += "III"; break;
                    case 4: resulRomNum += "IV"; break;
                    case 5: resulRomNum += "V"; break;
                    case 6: resulRomNum += "VI"; break;
                    case 7: resulRomNum += "VII"; break;
                    case 8: resulRomNum += "VIII"; break;
                    case 9: resulRomNum += "IX"; break;
                }
            }
            
            Console.WriteLine("To roman: {0}", resulRomNum);
        }
    }
}
