using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    public class Employee
    {
        private int EmployeeID { get; }
        private string FullName { get; }
        private double Salary { get; }

        public Employee(int id, string fullName, double salary)
        {
            Console.WriteLine($"Id :- {id}");
            Console.WriteLine($"Full Name :- {fullName}");
            Console.WriteLine($"Salary :- {salary}");
        }
        public void DisplayEmployeeIfo()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101,"John Doe",50000);
            Console.ReadLine();
        }
    }
}
