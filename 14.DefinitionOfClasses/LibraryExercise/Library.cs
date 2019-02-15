using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExercise
{
    public class Library
    {
        //fields
        private string libraryName = null;
        private List<Book> booksList = new List<Book>();

        //constructors
        public Library() :
            this(null)
        { }

        public Library(string libraryName) :
            this(libraryName, new List<Book>())
        { }

        public Library(string libraryName, List<Book> booksList)
        {
            this.libraryName = libraryName;
            this.booksList = booksList;
        }

        //properties
        public string LibraryName
        {
            get { return this.libraryName; }
            set { this.libraryName = value; }
        }

        public List<Book> BooksList
        {
            get { return this.booksList; }
            set { this.booksList = value; }
        }

        //methods
        public void AddBookToLibrary(Book newBook)
        {
            this.booksList.Add(newBook);
        }

        public void SearchBookByAuthorOrTitle(string titleOrAuthor)
        {
            bool isBookExist = false;
            foreach(Book book in this.booksList)
            {
                if (book.Title == titleOrAuthor || book.Author == titleOrAuthor)  
                {
                    Console.WriteLine(book);
                    isBookExist = true;
                }
            }

            if (!isBookExist) 
            {
                Console.WriteLine("There is no book with this title or author in the library!\n");
            }
        }

        public void DeleteBook(string titleOrAuthor)
        {
            for (int i = this.booksList.Count - 1; i >= 0; i--) 
            {
                if (this.booksList[i].Title == titleOrAuthor || this.booksList[i].Author == titleOrAuthor) 
                {
                    this.booksList.RemoveAt(i);
                }
            }
        } 
    }
}
