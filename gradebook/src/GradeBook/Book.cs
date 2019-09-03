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

        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }

        public void ShowStatistics() {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var result = 0.0;

            foreach (var number in grades) {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            var average = result / grades.Count;

            Console.WriteLine($"The average grade is {average:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
        }

        private List<double> grades;
        private string name;
    }
}