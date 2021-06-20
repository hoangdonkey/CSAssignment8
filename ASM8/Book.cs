using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM8
{
    class Book
    {
        private string isbn, bookTitle;
        private int bookId;
        public string ISBN
        {
            get { return isbn; }
            private set { isbn = value; }

        }
        public string BookTitle
        {
            get { return bookTitle; }
            private set { bookTitle = value; }

        }
        public int BookId
        {
            get { return bookId; }
            private set { bookId = value; }

        }

        public Book()
        {

        }
        public Book(string isbn, string bookTitle, int bookId)
        {
            this.isbn = isbn;
            this.bookTitle = bookTitle;
            this.bookId = bookId;
        }
    }
}
