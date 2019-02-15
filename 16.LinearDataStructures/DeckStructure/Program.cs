using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace DeckStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck testDeck = new Deck();

            testDeck.AddLeft(25); //bottom
            testDeck.AddLeft(234);
            testDeck.AddRight(1);
            testDeck.AddRight(256);
            testDeck.AddRight(333);

            Console.WriteLine("The numbers of all elements in the deck is: {0}", testDeck.Count);

            Console.WriteLine("Removed top element from the left is: {0}", testDeck.PopLeft());
            Console.WriteLine("\nThe numbers of all elements in the deck is: {0}", testDeck.Count);

            Console.WriteLine("\nRemoved top element from the right is: {0}", testDeck.PopRight());
            Console.WriteLine("\nRemoved top element from the right is: {0}", testDeck.PopRight());
            Console.WriteLine("\nThe numbers of all elements in the deck is: {0}", testDeck.Count);

            Console.WriteLine("The number of all elements in the left side of the deck is: {0}", 
                testDeck.CountLeft);
            Console.WriteLine("The number of all elements in the right side of the deck is: {0}",
               testDeck.CountRight);

            Console.WriteLine("The top element from the left side is: {0}", testDeck.PeekLeft());
            Console.WriteLine("The top element from the right side is: {0}", testDeck.PeekRight());

            Console.WriteLine("\nRemoved top element from the right is: {0}", testDeck.PopRight());
            Console.WriteLine("\nThe numbers of all elements in the deck is: {0}", testDeck.Count);
            Console.WriteLine("The top element from the left side is: {0}", testDeck.PeekLeft());

            //this will throw exception
            //Console.WriteLine("The top element from the right side is: {0}", testDeck.PeekRight());

            
            testDeck.AddLeft(234);
            testDeck.AddRight(1);
            testDeck.AddRight(256);
            testDeck.AddRight(333);
            Console.WriteLine("The numbers of all elements in the deck before clearing is: {0}", testDeck.Count);

            testDeck.Clear();
            Console.WriteLine("The numbers of all elements in the deck after clearing is: {0}", testDeck.Count);

        }
    }
}
