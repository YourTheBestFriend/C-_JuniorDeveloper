using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    class Book
    {
        public string name { get; set; }
        public string Author_name { get; set; }
        public Book() {}
        public Book(string name, string Author_name)
        {
            this.name = name;
            this.Author_name = Author_name;
        }
    }
}
