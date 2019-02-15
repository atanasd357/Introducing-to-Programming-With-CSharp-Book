using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace Binary_to_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter binary number: ");
            string num = Console.ReadLine();

            string tempResult = "";
            int numZeros = 0;
            string endResult = "";

            if ((num.Length) % 4 != 0)
            {
                numZeros = 4 - ((num.Length) % 4);
                num = (new string('0', numZeros)) + num;
            }

            for (int i = 0; i < num.Length; i = i + 4) 
            {
                for (int j = i; j < i+4; j++)
                {
                    tempResult += num[j];
                }

                switch(tempResult)
                {
                    case "0000": endResult += '0'; break;
                    case "0001": endResult += '1'; break;
                    case "0010": endResult += '2'; break;
                    case "0011": endResult += '3'; break;
                    case "0100": endResult += '4'; break;
                    case "0101": endResult += '5'; break;
                    case "0110": endResult += '6'; break;
                    case "0111": endResult += '7'; break;
                    case "1000": endResult += '8'; break;
                    case "1001": endResult += '9'; break;
                    case "1010": endResult += 'A'; break;
                    case "1011": endResult += 'B'; break;
                    case "1100": endResult += 'C'; break;
                    case "1101": endResult += 'D'; break;
                    case "1110": endResult += 'E'; break;
                    case "1111": endResult += 'F'; break;
                }
                tempResult = "";
            }

            Console.WriteLine("To hexadecimal: {0}", endResult);
        }
    }
}
