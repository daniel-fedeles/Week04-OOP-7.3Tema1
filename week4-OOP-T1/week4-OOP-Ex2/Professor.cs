using System;

namespace week4_OOP_Ex2
{
    public class Professor
    {
        public Professor(string name, string faculty, string specialization)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.Specialization = specialization;
        }

        private string Name;
        private string Faculty;
        private string Specialization;

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Faculty: {Faculty}, Specialization: {Specialization}");
        }
    }
}
