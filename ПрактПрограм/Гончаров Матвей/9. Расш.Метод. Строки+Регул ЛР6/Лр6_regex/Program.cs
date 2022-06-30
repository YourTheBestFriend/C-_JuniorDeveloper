using System;
using System.Text.RegularExpressions; // Для регулярок 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр6_regex
{
    public static class StringExt
    {
        // Расширяюший метод
        public static string Give_Slova_po_num(this string str, int num)
        {
            // new string 
            string new_str = "";
            // Кроме символов букв удаляю другие и ' - поставил чтобы не удалять оно в тексте
            Regex my_reg = new Regex(@"[^a-zA-Z']");
            str = my_reg.Replace(str, " "); // Важно не забыть пробел
            string[] array_word = str.Split(' '); // Разбиваю в массив строк по пробелам
            foreach (string item in array_word)
            {
                // Проверка на размерность слова
                if (item.Length == num)
                {
                    new_str += item + " ";
                }
            }
            return new_str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Even though Israel is a small country it is always in the news.
The news continues to report on Jews moving to Israel, on the technology invented there, but also on conflict,
wars and tensions with surrounding people.  Why? A look at Israel’s history in the book of Genesis in the Bible
reveals that 4000 years ago a man, who is now very well known, went on a camping trip in that part of the world.  
The Bible says that his story affects our future. This ancient man is Abraham (also known as Abram).  We can take 
his story seriously because the places and cities he visited are mentioned in other old writings.";
            int num = 10;
            Console.WriteLine(text.Give_Slova_po_num(num));
        }
    }
}
