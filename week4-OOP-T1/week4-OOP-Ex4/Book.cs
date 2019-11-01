using System;

namespace week4_OOP_Ex4
{
    public class Book
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public double Price { get; set; }


        public void Print()
        {
            Console.WriteLine($"Book name: {Name.ToUpper()}, Price: {Price}");
            Author.Print();
        }


    }
}
