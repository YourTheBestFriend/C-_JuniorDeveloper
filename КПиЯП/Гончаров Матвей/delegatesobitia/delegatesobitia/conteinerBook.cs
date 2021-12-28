using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesobitia
{
    class ConteinerBook
    {
        private List<Book> listBook;
        public ConteinerBook(List<Book> listBook)
        {
            this.listBook = listBook;
        }
        public ConteinerBook(params Book[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                listBook.Add(x[i]);
            }
        }

        // sort по Nazvanie
        public void SortListNazvanie()
        {
            for (int i = 1; i < listBook.Count; i++)
            {
                for (int j = 0; j < listBook.Count-1; j++)
                {
                    if (listBook[i-1].Nazvanie.Length > listBook[i].Nazvanie.Length)
                    {
                        // swap
                        string s = listBook[i - 1].Nazvanie;
                        listBook[i - 1].Nazvanie = listBook[i].Nazvanie;
                        listBook[i].Nazvanie = s;
                    }
                }
            }
        }
        // sort по Author
        public void SortListAuthor()
        {
            for (int i = 1; i < listBook.Count; i++)
            {
                for (int j = 0; j < listBook.Count - 1; j++)
                {
                    if (listBook[i - 1].Author.Length > listBook[i].Author.Length)
                    {
                        // swap
                        string s = listBook[i - 1].Author;
                        listBook[i - 1].Author = listBook[i].Author;
                        listBook[i].Author = s;
                    }
                }
            }
        }
        // sort по Izdatelstvo
        public void SortListIzdatelstvo()
        {
            for (int i = 1; i < listBook.Count; i++)
            {
                for (int j = 0; j < listBook.Count - 1; j++)
                {
                    if (listBook[i - 1].Izdatelstvo > listBook[i].Izdatelstvo)
                    {
                        // swap
                        int s = listBook[i - 1].Izdatelstvo;
                        listBook[i - 1].Izdatelstvo = listBook[i].Izdatelstvo;
                        listBook[i].Izdatelstvo = s;
                    }
                }
            }
        }

    }
}
