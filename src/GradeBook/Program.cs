﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> grades = new List<double>() { 7.7, 3.3, 10.10 };

            var result = 0.0;
            
            foreach (double number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            

        }
    }
}
