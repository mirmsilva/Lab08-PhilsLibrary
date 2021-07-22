using Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class MyLibrary : ILibrary
    {

        //create dictionary <key, value>
        //add the using statement
        //this is supposed to be private
        private Dictionary<string, Book> bookList = new Dictionary<string, Book>();

        public int Count => throw new NotImplementedException();

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            //create the Author Object
            Author name = new Author();
            name.FirstName = firstName;
            name.LastName = lastName;
            
            //create the Book Object
            Book book1 = new Book
            {
                Title = title,
                Author = name,
                Pages = numberOfPages,

            };
            bookList.Add(book1.Title, book1);
        }
        public Book Borrow(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Return(Book book)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


       
       
    }
}
