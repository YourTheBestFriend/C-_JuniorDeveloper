using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Классы
{
    class Libruary
    {
        List<Book> list_book = new List<Book>();
        public Libruary() { }
        public Libruary(params Book[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                list_book.Add(x[i]);
            }
        }
        public string au_book_for_num(int num)
        {
            foreach (var item in list_book)
            {
                if (item.kategory == num)
                {
                    return item.name_outhor;
                }
            }
            return "none";
        }
        public void addBook(params Book[] x)
        {
       //     list_book.AddRange(x);
            int i = 0;
            while (i < x.Length) // >=0
            {
                list_book.Add(x[i]);
                Console.WriteLine($"add Book: name_author = {x[i].name_outhor}, kategory = {x[i].kategory}");
                i++;
            }
        }
        public void deleteBook(params Book[] x)
        {
            int i = x.Length-1;
            while (i > -1) // >=0
            {
                list_book.Remove(x[i]);
                Console.WriteLine($"delete Book: name_author = {x[i].name_outhor}, kategory = {x[i].kategory}");
                i--;
            }
        }
        public void show()
        {
            Console.WriteLine("__Show__");
            foreach (var item in list_book)
            {
                Console.WriteLine($"author book = {item.name_outhor}, kategory = {item.kategory}");
            }
        }
    }
}
