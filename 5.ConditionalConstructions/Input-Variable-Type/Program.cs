using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace Input_Variable_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable type: ");
            string variableType = Console.ReadLine();

            switch (variableType)
            {
                case "int":
                    {
                        Console.Write("Input int number: ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine(num + 1);
                    };
                    break;
                case "double":
                    {
                        Console.Write("Input double number: ");
                        double num = int.Parse(Console.ReadLine());
                        Console.WriteLine(num + 1);
                    };
                    break;
                case "string":
                    {
                        Console.Write("Input text: ");
                        string text = Console.ReadLine();
                        Console.WriteLine(text+"*");
                    };
                    break;
                default: Console.WriteLine("Invalid variable");
                    break;     
            }
        }
    }
}
