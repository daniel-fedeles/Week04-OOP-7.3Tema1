using System;

namespace week4_OOP_Ex2
{
    public class Student
    {
        public Student(string name, string faculty, int year)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.Year = year;
        }
        private string Name;
        private string Faculty;
        private int Year;

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Faculty: {Faculty}, Year: {Year}");
        }
    }
}
