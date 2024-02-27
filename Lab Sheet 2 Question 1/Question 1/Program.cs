using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    public class Book
    {
        public string Title;
        public string Author;

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.Title = "Madolduwa";
            book.Author = "Martin";

            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.ReadLine();
        }
    }
}
