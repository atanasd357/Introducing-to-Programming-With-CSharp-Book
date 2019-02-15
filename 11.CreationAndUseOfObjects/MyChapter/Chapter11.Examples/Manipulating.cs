using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace MyChapter.Chapter11.Examples
{
    public class Manipulating
    {
        static void Main()
        {
            Console.WriteLine("Call class Cat:");
            Cat someCat = new Cat();
            someCat.SayMiau();
            Console.WriteLine("The color of cat {0} is {1}.", someCat.Name, someCat.Color);
            Console.WriteLine();
        
            someCat = new Cat("Raymond", "white");
            someCat.SayMiau();
            Console.WriteLine("The color of cat {0} is {1}.", someCat.Name, someCat.Color);
            Console.WriteLine();

            Console.WriteLine("Call class Sequence:");
            Console.WriteLine("Sequence[1...3]: {0}, {1}, {2}",
              Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());
            Console.WriteLine();

            TenCatsSaysMiau();
        }

        static void TenCatsSaysMiau()
        {
           Cat[] catArray = new Cat[10];
            for (int i = 0; i < catArray.Length; i++)
            {
                string catName = "Cat" + Sequence.NextValueParam(0 + i);
                catArray[i] = new Cat(catName);
            }

            for (int i = 0; i < catArray.Length; i++)
            {
                catArray[i].SayMiau();
            }
            Console.WriteLine();
        }
    }
}
