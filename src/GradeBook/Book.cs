using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void Addgrade(double grade)
        {
            grades.Add(grade);
        }
        public Stats GetStats()
        {
            var results = new Stats();
            results.Average = 0.0;
            results.High = double.MinValue;
            results.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                results.High = Math.Max(grade, results.High);
                results.Low = Math.Min(grade, results.Low);
                results.Average += grade;
            }
            results.Average /= grades.Count;
            return results;
        }
        private List<double> grades;
        public string Name;
    }
}