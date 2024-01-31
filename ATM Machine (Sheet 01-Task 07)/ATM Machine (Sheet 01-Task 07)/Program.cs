using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine__Sheet_01_Task_07_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balanc = 0;
            mainn(balanc);
        }
        static void mainn(int balance)
        {
            Console.WriteLine("Type the number what function you want :");
            Console.WriteLine("1. Check the balance");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Withdraw money");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                bal(balance);
            }
            else if (x == 2)
            {
                dep(balance);
            }
            else
            {
                with(balance);
            }
        }
        static void bal(int b)
        {
            Console.WriteLine($"The balance is : {b}");
            mainn(b);
        }
        static void dep(int d)
        {
            Console.WriteLine("Enter the amount, what you are going to deposit");
            int am = Convert.ToInt32(Console.ReadLine());
            d = d + am;
            Console.WriteLine($"Your balance is : {d}");
            mainn(d);
        }
        static void with(int w)
        {
            Console.WriteLine("Enter the amount, what you are going to withdraw");
            int wi = Convert.ToInt32(Console.ReadLine());
            w = w - wi;
            Console.WriteLine($"{wi} withdrawed.");
            Console.WriteLine($"Your balance is : {w}");
            mainn(w);
        }
    }
}
