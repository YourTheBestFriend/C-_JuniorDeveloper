using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesobitia
{
    class Book
    {
        // variables
        private string nazvanie;
        private string author;
        private int izdatelstvo;
        
        // property
        public string Nazvanie
        {
            get => nazvanie;
            set { nazvanie = value; }
        }
        public string Author
        {
            get => author;
            set { author = value; }
        }
        public int Izdatelstvo
        {
            get => izdatelstvo;
            set { izdatelstvo = value; }
        }
        // constructor
        public Book(string nazvanie, string author, int izdatelstvo)
        {
            this.nazvanie = nazvanie;
            this.author = author;
            this.izdatelstvo = izdatelstvo;
        }
    }
}
