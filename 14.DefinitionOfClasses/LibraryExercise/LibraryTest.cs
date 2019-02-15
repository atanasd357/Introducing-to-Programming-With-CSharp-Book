using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExercise
{
    public class LibraryTest
    {
        public static void TestTheLibrary()
        {
            //making My library and add books
            Library myLibrary = new Library("My library");
            myLibrary.AddBookToLibrary(new Book("How to Win Friends and Influence People", "Dale Carnegie",
                "Simon and Schuster", 1936, 1439167346));
            myLibrary.AddBookToLibrary(new Book("Zen and the Art of Motorcycle Maintenance", "Robert Pirsig",
                "William Morrow and Company", 1974, 0688002307));
            myLibrary.AddBookToLibrary(new Book("Carrie", "Stephen King", "Doubleday", 1974, 0385086954));
            myLibrary.AddBookToLibrary(new Book("Rage", "Stephen King", "Signet Books", 1977, 9780451076458));
            myLibrary.AddBookToLibrary(new Book("Lila: An Inquiry into Morals", "Robert Pirsig",
                "Bantam Books", 1991, 0553078739));
            myLibrary.AddBookToLibrary(new Book("The 7 Habits of Highly Effective People", "Stephen Kovi",
                "Free Press", 1989, 0743269519));
            myLibrary.AddBookToLibrary(new Book("Insomnia", "Stephen King", "Viking", 1994, 9780670855032));
            myLibrary.AddBookToLibrary(new Book("Book of Dreams", "Jack Kerouac",
                "City Lights Press", 1960, 0872863808));
            myLibrary.AddBookToLibrary(new Book("Black House", "Stephen King", "Random House", 2001, 9780375504396));
            myLibrary.AddBookToLibrary(new Book("On the Road", "Jack Kerouac", "Viking", 1957));
            myLibrary.AddBookToLibrary(new Book("How to Stop Worrying and Start Living", "Dale Carnegie",
                "Simon and Schuster", 1948, 0671035975));
            myLibrary.AddBookToLibrary(new Book("End of Watch", "Stephen King", "Scribner", 2016, 9781501129742));

            //print all books from my library
            Console.WriteLine("Books in {0}", myLibrary.LibraryName);
            Console.WriteLine("---------------------------------\n");

            foreach (Book book in myLibrary.BooksList)
            {
                Console.WriteLine(book);
            }

            //delete books from a specified author
            myLibrary.DeleteBook("Stephen King");

            //print the remaining books after deletion
            foreach (Book book in myLibrary.BooksList)
            {
                Console.WriteLine(book);
            }

            //search and print info for books from a specified author
            Console.WriteLine("Search for book with author Stephen King:");
            myLibrary.SearchBookByAuthorOrTitle("Stephen King");
        }
    }
}
