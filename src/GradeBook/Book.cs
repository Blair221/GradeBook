using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void Addgrade(double grade)
        {
            grades.Add(grade);
        }
        public void ShowStats()
        {
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
        private List<double> grades;
        private string name;
    }
}