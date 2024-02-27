using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    public class Product
    {
        public string ProductName;
        public int Price;

        public Product(string ProductName,int Price)
        {
            Console.WriteLine("Product Name : "+ProductName);
            Console.WriteLine("Product Price : " + Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Rice",100);
            Product product1 = new Product("Milk", 800);
            Console.ReadLine();
        }
    }
}
