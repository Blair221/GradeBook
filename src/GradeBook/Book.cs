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
        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }
        public Stats GetStats()
        {
            var results = new Stats();
            results.Average = 0.0;
            results.High = double.MinValue;
            results.Low = double.MaxValue;

            for (int i = 0; i < grades.Count; i++)
            {
                results.High = Math.Max(grades[i], results.High);
                results.Low = Math.Min(grades[i], results.Low);
                results.Average += grades[i];
            }
            results.Average /= grades.Count;

            switch (results.Average)
            {
                case var d when d >= 90.0:
                    results.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    results.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    results.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    results.Letter = 'D';
                    break;
                default:
                    results.Letter = 'D';
                    break;
            }

            return results;
        }
        private List<double> grades;

        public string Name
        {
            get; 
            private set;
        }

        public const string CATEGORY= "Science";
    }
}