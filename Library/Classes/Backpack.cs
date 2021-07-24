using Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Backpack : IBag<Book>
    {
        private List<Book> books { get; set; }
        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Pack(Book item)
        {
            books.Add(item);
        }

        public Book Unpack(int index)
        {
            Book removedBook = books.ElementAt(index);
            books.RemoveAt(index);
            return removedBook;
        }
        public string ShowBooks()
        {
            string bookList = "";
            foreach( Book book in books)
            {
                bookList += book.Title;
            }
            return bookList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
