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
        // Главная функция которая инициализируется делегату и принимает параметр который определяет как сортировать
        public void SortListBook(int p)
        {
            switch (p)
            {
                case 1:
                    SortListNazvanie();
                    break;
                case 2:
                    SortListAuthor();
                    break;
                case 3:
                    SortListIzdatelstvo();
                    break;
                default:
                    Console.WriteLine("Значит вы ничего не выбрали");
                    break;
            }
        }

        // sort по Nazvanie
        public void SortListNazvanie()
        {
            for (int j = 0; j < listBook.Count; j++)
            {
                for (int i = 1; i < listBook.Count; i++)
                {
                    ///................................................................................... ИЛИ ПРИМЕЧАНИЕ
                    /*
                     После того как я это написал, подумал что наверное надо было написать одну функции сортировки и тупо в проверк через делегат c ПЕРЕДАЧЕЙ параметра СОРТИРОВКИ и еще одну функцию возвращать true или false 
                     
                    А тут я реализовал метод, в котором тупо выборка, присовел его делегату и через него вызываю функции эти
                     */

                    // Понястно что можно сортануть по другому, я прост увидел такой прикол и решил через него сделать, понятно что можно было сделать через интерфейс...
                    // string str = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                    string str = @"abcdefghijklmnopqrstuvwxyz";
                    // Для проверки
                    // Console.WriteLine($"_____________ {str.IndexOf(listBook[i - 1].Nazvanie.ToLower()[0])} ___________ {str.IndexOf(listBook[i].Nazvanie.ToLower()[0])}");
                    if (str.IndexOf(listBook[i - 1].Nazvanie.ToLower()[0]) > str.IndexOf(listBook[i].Nazvanie.ToLower()[0])) // str.IndexOf(listBook[i].Nazvanie[0]) / 2 (индекс элемента)
                    {
                        // swap по всему
                        // Nazvanie
                        string s = listBook[i - 1].Nazvanie;
                        listBook[i - 1].Nazvanie = listBook[i].Nazvanie;
                        listBook[i].Nazvanie = s;

                        // Author
                        s = listBook[i - 1].Author;
                        listBook[i - 1].Author = listBook[i].Author;
                        listBook[i].Author = s;

                        // Izdatelstvo
                        int x = listBook[i - 1].Izdatelstvo;
                        listBook[i - 1].Izdatelstvo = listBook[i].Izdatelstvo;
                        listBook[i].Izdatelstvo = x;
                    }
                }
            }
        }
        // sort по Author
        public void SortListAuthor()
        {
            for (int j = 0; j < listBook.Count; j++)
            {
                for (int i = 1; i < listBook.Count; i++)
                {
                    //string str = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                    string str = @"abcdefghijklmnopqrstuvwxyz";
                    if (str.IndexOf(listBook[i - 1].Author.ToLower()[0]) > str.IndexOf(listBook[i].Author.ToLower()[0]))
                    {
                        // swap по всему
                        // Nazvanie
                        string s = listBook[i - 1].Nazvanie;
                        listBook[i - 1].Nazvanie = listBook[i].Nazvanie;
                        listBook[i].Nazvanie = s;

                        // Author
                        s = listBook[i - 1].Author;
                        listBook[i - 1].Author = listBook[i].Author;
                        listBook[i].Author = s;

                        // Izdatelstvo
                        int x = listBook[i - 1].Izdatelstvo;
                        listBook[i - 1].Izdatelstvo = listBook[i].Izdatelstvo;
                        listBook[i].Izdatelstvo = x;
                    }
                }
            }
        }
        // sort по Izdatelstvo
        public void SortListIzdatelstvo()
        {
            for (int j = 0; j < listBook.Count; j++)
            {
                for (int i = 1; i < listBook.Count; i++)
                {
                    if (listBook[i - 1].Izdatelstvo > listBook[i].Izdatelstvo)
                    {
                        // swap по всему
                        // Nazvanie
                        string s = listBook[i - 1].Nazvanie;
                        listBook[i - 1].Nazvanie = listBook[i].Nazvanie;
                        listBook[i].Nazvanie = s;

                        // Author
                        s = listBook[i - 1].Author;
                        listBook[i - 1].Author = listBook[i].Author;
                        listBook[i].Author = s;

                        // Izdatelstvo
                        int x = listBook[i - 1].Izdatelstvo;
                        listBook[i - 1].Izdatelstvo = listBook[i].Izdatelstvo;
                        listBook[i].Izdatelstvo = x;
                    }
                }
            }
        }
        // Для проверки написал метод чтобы все просто вывело а не через переоперделение ToStrgin()
        public void PrintAllData()
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                Console.WriteLine($"listbook[{i}]: Название = {listBook[i].Nazvanie} | Автор {listBook[i].Author} | Изда тельство {listBook[i].Izdatelstvo}.");
            }
        }
    }
}
