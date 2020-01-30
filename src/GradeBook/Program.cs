using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Blair's GradeBook");
            book.Addgrade(89.1);
            book.Addgrade(90.2);
            book.Addgrade(76.4);



            List<double> grades = new List<double>() { 7.7, 3.3, 10.10 };

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N2}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The Lowest grade is {lowGrade:N2}");


        }
    }
}
