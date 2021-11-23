using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Классы
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Albert", 7);
            Book book2 = new Book("Vasy", 8);
            Book book3 = new Book("Petr", 9);

            Book book4 = new Book("Matvey", 1);

            Libruary lib = new Libruary(book1, book2, book3);
            lib.show();
            lib.deleteBook(book2);
            lib.show();
            lib.addBook(book4);
            lib.show();

            bool b = book1 == book4;
            Console.WriteLine($"(kategory != False == True) book1 == book4 = {b}");

            Book book5 = new Book("Mariya", 10);
            lib + book5;
            lib.show();


        }
    }
}
