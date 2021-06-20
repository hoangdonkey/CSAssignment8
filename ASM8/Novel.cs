using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM8
{
    class Novel
    {
        public Book[] books;
        public Novel(int length)
        {
            books = new Book[length];
        }
        public Book this[int index]
        {
            get
            {
                if (index < 0 || index > books.Length)
                {
                    return null;
                }
                else
                {
                    return books[index];
                }
            }
            set
            {

                if (index < 0 || index > books.Length)
                {
                    books[index] = null;
                }
                else
                {
                    books[index] = value;
                }

            }
        }
        public void DisplayInfor()
        {
            Console.WriteLine("Book ID\t\tBook Name\t\t\tISBN Number\n" +
                              "-------\t\t---------\t\t\t-----------");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.BookId}\t\t{book.BookTitle}\t\t\t{book.ISBN}");
            }
        }
    }
}
