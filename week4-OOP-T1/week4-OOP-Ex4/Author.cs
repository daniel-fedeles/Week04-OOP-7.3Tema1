using System;

namespace week4_OOP_Ex4
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public void Print()
        {
            Console.WriteLine($"All about author: {Name}, {Email}, {Country}");
        }
    }
}
