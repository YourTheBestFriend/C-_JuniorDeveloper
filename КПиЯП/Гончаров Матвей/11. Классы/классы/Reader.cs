using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    class Reader
    {
        public string FIO { get; set; }
        public int numberRead { get; set; }
        public string Fakultet { get; set; }
        public int date { get; set; }
        public int honeNumber { get; set; }

        public Reader() {}
        public Reader(string FIO, int numberRead, string Fakultet, int date, int honeNumber)
        {
            this.FIO = FIO;
            this.numberRead = numberRead;
            this.Fakultet = Fakultet;
            this.date = date;
            this.honeNumber = honeNumber;
        }

        public void takeBook(int x)
        {
            Console.WriteLine($"{FIO} + взял {x} книг(и)");
        }
        public void takeBook(params string[] books)
        {
            Console.Write($"{FIO} взял книги ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write(books[i]);
                if (i == books.Length - 1)
                {
                    Console.WriteLine(".");
                }
                else 
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }

        public void takeBook(params Book[] books)
        {
            Console.Write($"{FIO} взял книги ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write(books[i].name);
                if (i == books.Length - 1)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
        public void returnBook(string book)
        {
            Console.Write($"{FIO} читает - {book}");
        }

        public void returnBook(int x)
        {
            Console.Write($"{FIO} вернул {x} книг(и)");
        }
        public void returnBook(params string[] books)
        {
            Console.Write($"{FIO} вернул книги ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write(books[i]);
                if (i == books.Length - 1)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}
