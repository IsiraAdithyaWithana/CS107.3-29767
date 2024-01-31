using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the legth of the rectangle");
            Double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the heigth of the rectangle");
            Double heigth = Convert.ToDouble(Console.ReadLine());

            Double area = heigth * length;

            Console.WriteLine($"The area is {area}");
            Console.ReadLine();
        }
    }
}