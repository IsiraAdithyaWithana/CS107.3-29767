using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your marks here :");
            int x = Convert.ToInt32(Console.ReadLine());
            string s;

            if (x < 0 || x > 100)
            {
                s = "Error";
            }
            else
            {
                if (x >= 75)
                {
                    s = "A";
                }
                else if(x >= 60)
                {
                    s = "B";
                }
                else if (x >= 50)
                {
                    s = "C";
                }
                else if (x >= 40)
                {
                    s = "D";
                }
                else
                {
                    s = "Failed";
                }
            }
            Console.WriteLine(name + " : " + s);
        }
    }
}
