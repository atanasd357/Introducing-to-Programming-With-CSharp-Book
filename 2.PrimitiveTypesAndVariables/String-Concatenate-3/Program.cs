using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace String_Concatenate_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "\"use\"";
            string secondStr = $"The {firstStr} of quotations causes difficulties.";
            string thirdStr = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(secondStr);
            Console.WriteLine(thirdStr);
        }
    }
}
