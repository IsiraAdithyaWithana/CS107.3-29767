using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimensions(5, 3);
            Console.WriteLine("Rectangle:");
            rectangle.DisplayShapeInfo();

            
            Circle circle = new Circle();
            circle.SetRadius(4);
            Console.WriteLine("\nCircle:");
            circle.DisplayShapeInfo();

            Console.ReadLine();
        }
    }

    public class Shape
    {
        public string ShapeType;
        public double Area;


        
        public virtual void CalculateArea(double val1, double val2 = 0)
        {
            
        }

        
        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Area: {Area}");
        }
    }


    public class Rectangle : Shape
    {
        private double length;
        private double width;


        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea(length, width);
        }

        public override void CalculateArea(double length, double width)
        {
            Area = length * width;
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"Length: {length}, Width: {width}");
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
            CalculateArea(radius);
        }
        public override void CalculateArea(double radius, double dummy = 0)
        {
            Area = Math.PI * radius * radius;
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"Radius: {radius}");
        }
    }
}
