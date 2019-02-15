using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace HelloName
{
    public class HelloName
    {
        static void Main(string[] args)
        {
            Console.Write("Input name: ");
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static string PrintName(string name)
        {
            return string.Format("Hello, {0}!", name);
        }
    }
}
