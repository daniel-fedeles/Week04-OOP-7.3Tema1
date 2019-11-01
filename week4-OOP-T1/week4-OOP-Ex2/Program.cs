using System.Collections.Generic;

namespace week4_OOP_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Professor prof = new Professor("UNU", "AIA", "Ceva");
            Student stud = new Student("Studen1", "AIA", 2);
            students.Add(stud);
            Course course = new Course("IP", prof, 2, students);
            course.Print();

        }
    }
}
