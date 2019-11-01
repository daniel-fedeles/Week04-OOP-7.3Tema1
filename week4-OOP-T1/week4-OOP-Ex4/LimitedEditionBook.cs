using System;

namespace week4_OOP_Ex4
{
    public class LimitedEditionBook
    {
        public Book Book { get; set; }
        public void Print()
        {
            Book.Print();
            Console.WriteLine($"This book is limited edition ");
        }
    }
}
