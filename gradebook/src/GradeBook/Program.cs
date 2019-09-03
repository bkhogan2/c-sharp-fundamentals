using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Brian's Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(99.9);
            book.ShowStatistics();
        }
    }
}
