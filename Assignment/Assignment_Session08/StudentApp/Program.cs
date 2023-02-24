﻿using StudentApp.Model;
using System;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(101, "Gautam Kumar Pandey", 8.5);
            PrintDetails(student1);

            Console.WriteLine();
            Student student2 = new Student(101, "Ga", 8.5);
            PrintDetails(student2);

            Console.WriteLine();
            Student student3 = new Student(-10, "Gautam", 8.5);
            PrintDetails(student3);

            Console.WriteLine();
            Student student4 = new Student(10, "Gautam", 19.00);
            PrintDetails(student4);
        }

        private static void PrintDetails(Student student)
        {
            Console.WriteLine("Roll Number is : "+student.RollNo);
            Console.WriteLine("Name is : " + student.Name);
            Console.WriteLine("CGPA is : " + student.Cgpa);
            Console.WriteLine("Percentage is : " + student.CalculatePercentage());
        }
    }
}
