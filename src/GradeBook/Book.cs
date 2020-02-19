using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Stats GetStats();
    }

    public interface IBook 
    {
        void AddGrade(double grade);
        Stats GetStats();
        string Name { get;}
        event GradeAddedDelegate GradeAdded;
    }

    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
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
        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }
        public override event GradeAddedDelegate GradeAdded;
        public override Stats GetStats()
        {
            var results = new Stats();

            for (int i = 0; i < grades.Count; i++)
            {
                results.Add(grades[i]);
            }

            return results;
        }
        private List<double> grades;


        public const string CATEGORY = "Science";
    }
}