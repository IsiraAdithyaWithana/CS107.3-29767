using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    public class Product
    {
        private int productId { get; }
        private string productName { get; }
        private double price { get; }
        private int quantityInStock { get; }
        public Product(int productId, string productName, double price,  int quantityInStock)
        {
            Console.WriteLine("Product ID : " + productId);
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Product Price : " + price);
            Console.WriteLine("Product Quality in stock : " + quantityInStock);
        }
        public void AddProduct()
        {

        }
        public void BuyProduct()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101, "Laptop", 800, 10);

            Console.ReadLine();
        }
    }
}
