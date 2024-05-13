using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    public class Course
    {
        private string courseName, instructorName;
        private double grade;

        public string CourseName => courseName;//we can give access for read only by =>.
        public double Grade => grade;


        public void SetInstructorName(string instructor)
        {
            if (string.IsNullOrEmpty(instructor))
                throw new ArgumentException("Instructor name cannot be empty.");
            instructorName = instructor;
        }

        private string CalculateLetterGrade()
        {
            // Implement your logic to calculate the letter grade based on the numeric grade.
            // Example: if grade >= 90, return "A", etc.
            // You can use a switch statement or if-else conditions.
        }

        public void PrintCourseInfo()
        {
            string letterGrade = CalculateLetterGrade();
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Instructor: {instructorName}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Course class and test its methods.
            // Example usage:
            Course myCourse = new Course();
            myCourse.SetInstructorName("John Doe");
            myCourse.PrintCourseInfo();
        }
    }
}
