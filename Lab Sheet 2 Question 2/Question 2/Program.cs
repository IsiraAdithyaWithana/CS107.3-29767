using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    public class BankAccount
    {
        public int AccountNumber;
        private double Balance;

        public double Bbalance
        {
            get { return Balance; } 
            set { Balance = value; }
        }

        public void Deposit()
        {
            for(bool x = true; x == true; )
            {
                Console.WriteLine("Your balance is " + Bbalance);
                Console.WriteLine("Please deposit some money");
                double amount = Convert.ToDouble(Console.ReadLine());
                Bbalance += amount;
                Console.WriteLine("Now your Balance is " + Bbalance);
                Console.WriteLine("If you want to stop press 's'");
                Console.WriteLine("If you want to continue press 'c'");
                string a = Console.ReadLine();
                if (a == "s")
                {
                    x = false;
                }
                else
                {
                    x = true;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit();
        }
    }
}
