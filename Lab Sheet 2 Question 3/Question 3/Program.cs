using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class TemperatureTracker
    {
        public double[] Daily;

        public void InputTemp()
        {
            for (bool x=true; x == true; )
            {
                Console.WriteLine("Enter the current temperature");
                double itm = Convert.ToDouble(Console.ReadLine());
                Daily = new double[] {itm};
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
        public void WeekReport()
        {
            int a = Daily.Length;
            for(int i = 0; i < (a/7)+1; i++)
            {
                Console.WriteLine($"This is the week {i + 1} temperature report :-");
                if (i == (a / 7))
                {
                    for (int e = 0; e< (7 - ((((a % 7) + 1) * 7) - a)); e++)
                    {
                        Console.WriteLine($"{e+1}.  {Daily[(i*7)+e]}");
                    }
                }
                else
                {
                    for(int e = 0; e < 7; e++)
                    {
                        Console.WriteLine($"{e + 1}.  {Daily[((i * 7) + e)]}");
                    }
                }                
            }
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker inputTemp = new TemperatureTracker();

            inputTemp.InputTemp();
            inputTemp.WeekReport();
        }
    }
}
