using System;
using System.Collections.Generic;
using Library.Classes;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyLibrary library = new MyLibrary();

            Backpack backpack = new Backpack();

            AddBook(library);
            BorrowBook(library, backpack);
        }

        //create a method for the user to add books 
        //request title, first, last, page
        public static void AddBook(MyLibrary library)
        {
            Console.WriteLine("Book Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Author's First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Author's Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Book Pages:");
            int pages = Convert.ToInt32(Console.ReadLine());

            library.Add(title, firstName, lastName, pages);
        }

        //create a method  to borrow a book
        //will need title
        //parameters will need to be library and Backpack(?)
        public static void BorrowBook(MyLibrary library, Backpack backpack)
        {
            Console.WriteLine("Which book would you like to borrow?");
            string title = Console.ReadLine();

            //somehow the title needs to be added to the backpack
            //use borrow from library method somehow to borrow
            //use pack from backpack method to pack it into your backpack
            backpack.Pack();
        }
    }
}
