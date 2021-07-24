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
        private Dictionary<string, Book> BookList = new Dictionary<string, Book>();

        //set the book count to zero
        public int Count = 0;

        //why is this here? I DON'T KNOW!
        int IReadOnlyCollection<Book>.Count => throw new NotImplementedException();

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            //create the Author Object
            Author name = new Author();
            name.FirstName = firstName;
            name.LastName = lastName;
            
            //create the Book Object
            Book book = new Book
            {
                Title = title,
                Author = name,
                Pages = numberOfPages,

            };
            BookList.Add(book.Title, book);
        }
        public Book Borrow(string title)
        {
            Book borrowedBook = BookList.GetValueOrDefault(title);
            BookList.Remove(title);
            //the book count should go down
            Count--;
            Console.WriteLine($"You borrow the book {title}");
            return borrowedBook;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach( Book book in BookList.Values)
            {
                yield return book; 
            }
        }

        public void Return(Book book)
        {
            BookList.Add(book.Title, book);
            Count++;
        }

        //This is from John. He stated it should always look like this
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
