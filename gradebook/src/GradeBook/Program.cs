﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Brian's Gradebook");
            book.GradeAdded += OnGradeAdded;


            while (true){
                Console.WriteLine("Please enter the next grade.");
                var input = Console.ReadLine();
                if (input == "exit") {
                    break;
                }

                try {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex) {
                    System.Console.WriteLine(ex.Message);
                }
                finally{
                    Console.WriteLine("**");
                }
            }
            
            var stats = book.GetStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        static void OnGradeAdded(object sender, EventArgs e) {
            Console.WriteLine("A grade was added");
        }
    }
}
