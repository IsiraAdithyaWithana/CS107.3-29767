using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                for (; number>=1 ; number--)
                {
                    sum = sum + number;
                }

            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();
        }
    }
}
