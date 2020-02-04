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
            var stats = book.GetStats();
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The Lowest grade is {stats.Low}");
        }
    }
}
