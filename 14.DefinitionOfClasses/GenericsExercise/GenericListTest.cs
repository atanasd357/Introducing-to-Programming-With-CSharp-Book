using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    public class GenericListTest
    {
        public static void TestGenericList()
        {
            //create list with string values
            GenericList<string> nameList = new GenericList<string>(10);

            //fill the list
            nameList.AddElement("Ivan");
            nameList.AddElement("Veselin");
            nameList.AddElement("Gergana");
            nameList.AddElement("Kristian");
            nameList.AddElement("Atanas");
            nameList.AddElement("Kostadin");
            nameList.AddElement("Diana");
            nameList.AddElement("Marko");
            nameList.AddElement("Tsvetelina");
            nameList.AddElement("Vasil");

            Console.WriteLine("The initial list:");
            Console.WriteLine(nameList);

            //access element at given position
            string testElement = nameList.AccessElement(2);
            Console.Write("Accessed element: ");
            Console.WriteLine(testElement + "\n");

            //remove element from given position
            nameList.RemoveElement(1);
            Console.WriteLine("The list without element removed by the RemoveElement method:");
            Console.WriteLine(nameList);

            //insert element into a given position
            nameList.InsertElementAtPosition("Viktor", 3);
            nameList.InsertElementAtPosition("Viktor", 6);
            Console.WriteLine("The list after inserted elements:");
            Console.WriteLine(nameList);

            //search element by value
            nameList.SearchElementByValue("Viktor");
            Console.WriteLine();

            //add more elements to the full list
            nameList.AddElement("Petar");
            nameList.AddElement("Ivana");
            nameList.AddElement("Aleksandar");
            Console.WriteLine("The list after adding more elements:");
            Console.WriteLine(nameList);

            //clear the list
            nameList.ClearList();
            Console.WriteLine("The list after clearing:");
            Console.WriteLine(nameList);
        }
    }
}
