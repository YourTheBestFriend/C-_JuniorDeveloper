using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Классы
{
    class Book
    {
        public string name_outhor;
        public int kategory;
        public Book() { }
        public Book(string name_outhor, int kategory)
        {
            this.name_outhor = name_outhor;
            this.kategory = kategory;
        }
        public static bool operator !=(Book a, Book b)
        {
            return a.name_outhor != b.name_outhor;
        }
        public static bool operator ==(Book a, Book b)
        {
            return a.name_outhor == b.name_outhor;
        }
    }
}



