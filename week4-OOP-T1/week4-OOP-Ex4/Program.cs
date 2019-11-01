using System.Collections.Generic;

namespace week4_OOP_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>();
            Author author = new Author { Name = "Kent", Country = "Ceva", Email = null };
            Book book1 = new Book { Name = "o Carte buNa", Author = author, Price = 2350 };
            Book book2 = new Book { Name = "o alTa Carte buNa", Author = author, Price = 5630 };
            Book book3 = new Book { Name = "o alTa Carte", Author = author, Price = 1246 };
            Book book4 = new Book { Name = "o Carte liMiTata", Author = author, Price = 6350 };
            Book book5 = new Book { Name = "o alTa Carte LimiTata", Author = author, Price = 5690 };
            LimitedEditionBook limitedEditionBook1 = new LimitedEditionBook { Book = book4 };
            LimitedEditionBook limitedEditionBook2 = new LimitedEditionBook { Book = book5 };



        }
    }
}
