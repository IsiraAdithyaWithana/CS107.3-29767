using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int fibo = fib(number);
            
            Console.WriteLine($"The fibonacci value is {fibo}");
            Console.ReadLine();
        }

        static int fib(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return fib(x - 1) + fib(x - 2);
            }
        }
    }
}
