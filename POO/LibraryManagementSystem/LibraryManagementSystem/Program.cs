using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the library name: ");
            string libraryName = Console.ReadLine();

            Console.Write("Enter the maximum number of books in the library: ");
            int maxBooks = int.Parse(Console.ReadLine());

            Library myLibrary = new Library(libraryName, maxBooks);

            Console.WriteLine("\nEnter book titles: ");
            do
            {
                string input = Console.ReadLine();
                myLibrary.AddBook(input);
                maxBooks--;
            } while (maxBooks > 0);

            myLibrary.DisplayBooks();
        }
    }
}
