using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to display the multiplication table");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < 12; a++)
            {
                Console.WriteLine($"{a + 1} x {x} = {(a + 1) * x}");
            }
        }
    }
}
