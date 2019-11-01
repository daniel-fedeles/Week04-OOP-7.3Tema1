using System;
using System.Collections.Generic;

namespace week4_OOP_Ex2
{
    public class Course
    {
        public Course(string name, Professor prof, int year, List<Student> students)
        {
            this.Name = name;
            this.Professor = prof;
            this.Studenti = students;
            this.Year = year;
        }

        private string Name;
        private Professor Professor;
        private int Year;
        private List<Student> Studenti;

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Professor: {Professor}, Year: {Year}");
            Professor.Print();
            foreach (var student in Studenti)
            {
                student.Print();
            }
        }
    }
}
