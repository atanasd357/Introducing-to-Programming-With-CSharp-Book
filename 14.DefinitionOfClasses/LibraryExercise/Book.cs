using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExercise
{
    public class Book
    {
        //fields
        private string title = null;
        private string author = null;
        private string publisher = null;
        private ushort yearOfPublication = 0;
        private ulong ISBNNumber = 0;

        //constructors
        public Book() :
            this(null)
        { }

        public Book(string title) :
            this(title, null)
        { }

        public Book(string title, string author) :
            this(title, author, "not specified")
        { }

        public Book(string title, string author, string publisher) :
            this(title, author, publisher, 0)
        { }

        public Book(string title, string author, string publisher, ushort yearOfPublication) :
            this(title, author, publisher, yearOfPublication, 0)
        { }

        public Book(string title, string author, string publisher, ushort yearOfPublication, ulong ISBNNumber)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.yearOfPublication = yearOfPublication;
            this.ISBNNumber = ISBNNumber;
        }

        //properties
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        public ushort YearOfPublication
        {
            get { return this.yearOfPublication; }
            set { this.yearOfPublication = value; }
        }

        public ulong ISBN
        {
            get { return this.ISBNNumber; }
            set { this.ISBNNumber = value; }
        }

        //override method
        public override string ToString()
        {
            StringBuilder bookInfoPrint = new StringBuilder();
            bookInfoPrint.AppendLine("-----Book Info-----");
            bookInfoPrint.AppendLine("Title: " + this.title);
            bookInfoPrint.AppendLine("Author: " + this.author);
            bookInfoPrint.AppendLine("Publisher: " + this.publisher);
            bookInfoPrint.AppendLine("Year of publication: " + this.yearOfPublication);
            bookInfoPrint.AppendLine("ISBN number: " + this.ISBNNumber);
            bookInfoPrint.AppendLine();

            return bookInfoPrint.ToString();
        }
    }
}
