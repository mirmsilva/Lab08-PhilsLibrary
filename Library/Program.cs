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
            library.Add("Tjs", "miriam", "silva", 200);
        }
    }
}