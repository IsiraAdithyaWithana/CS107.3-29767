using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_05
{
    public class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Available;

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }
        public void BorrowBook()
        {
            if(Available==true)
            {
                Console.WriteLine("The book is available. You can buy it now. Press 'b' to buy");
                string x = Console.ReadLine();
                if (x == "b")
                {
                    Available = false;
                    Console.WriteLine($"{Title} book is burrowed");
                    Console.WriteLine($"{Title} availability is '{Available}'");
                }
                else
                {
                    Console.WriteLine("The book is not there");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook buy1 = new LibraryBook("Madol duwa", "Martin Wikrama", true);
            Console.ReadLine();
        }
    }
}
