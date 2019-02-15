using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace String_Concatenate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "Hello";
            string secondStr = "World";
            object result = firstStr + " " + secondStr;
            string thirdStr = (string)result;
            Console.WriteLine(thirdStr);
        }
    }
}
