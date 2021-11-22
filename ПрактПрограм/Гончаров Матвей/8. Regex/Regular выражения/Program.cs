using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_выражения
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1 1.2
            Console.WriteLine("Task 1.1");
            string s = "№: 23-45-2_1434"; // 11
            // регулярка
            Regex reg = new Regex(@"(\w)\1");
            if (reg.IsMatch(s))
            {
                Console.WriteLine($"Произведен корректный набор");
            }
            else 
            {
                Console.WriteLine($"Произведен не корректный набор");
            }
            Console.WriteLine("Task 1.2");
            // паспорт
            Regex pasport_reg = new Regex(@"^(AB|BM|HB|KH|MP|MC|KB|PP|SP|DP)[0-9]{7}$");
            string pasport = "AB1234567";
            if (pasport_reg.IsMatch(pasport))
            {
                Console.WriteLine($"Произведен корректный набор");
            }
            else
            {
                Console.WriteLine($"Произведен не корректный набор");
            }


            // 2
            string html_page = @"<!DOCTYPE html>
< html >
< head >
< title > Page Title </ title >
</ head >
< body style=''background-color:          #ABCPEF;''>
      < h1 > This is a Heading </ h1 >
   < p > This is a paragraph.</ p >
</ body >
</ html > ";

            // 1
            Console.WriteLine("\nTask1");
            Regex reg2 = new Regex(@"\w*background-color:[ ]*#[A-F0-9]{6}\w*",RegexOptions.IgnoreCase); // [ ] - тут пробел
            if (reg2.IsMatch(html_page))
            {
                Console.WriteLine($"Пользователь ввел color");
            }
            else
            {
                Console.WriteLine($"Пользователь не ввел color");
            }

            // 2
            Console.WriteLine("\nTask2");
            string my_text = "Привет, это текст кот!!! ДА кот7, не кasdfот да ко3т допустим 3кот245324 который";
            Regex reg3 = new Regex(@"\bкот\b");
            my_text = reg3.Replace(my_text, "котик");
            Console.WriteLine(my_text);

            // 3 работает на одну дату(время)
            // (0\d|1\d|2[0-3])[:][0-5][0-9][:][0-5][0-9]
            Console.WriteLine("\nTask3");
            //FileStream f = new FileStream("text.txt", FileMode.OpenOrCreate);
            Regex reg4 = new Regex(@"\w*((0\d|1\d|2[0-3]):([0-5][0-9])[:]([0-5][0-9])(.*?)?)");
            //string[] str;
            int fl = 0;
            var str = System.IO.File.ReadAllLines("C:\\Users\\Xhref\\Desktop\\C#\\УП\\Regular выражения\\Regular выражения\\text.txt");//.Skip(i).First();
            for (int i = 0; i < str.Length; i++)
            {
                // fl = 0;
                    fl = 0;
                foreach (Match m in reg4.Matches(str[i]))
                {  // Построчное считывание
                    if (m.Success)
                    {
                        fl++;
                 //       Console.WriteLine(m.Value);
                    }
                    if (fl >= 2) Console.WriteLine(str[i]);
                }
            }
            Console.WriteLine($"Кол-во строк: {fl}");
        }
    }
}


//Regex reg = new Regex(@"Sausages?");
//Match r = reg.Match("Sausages");
//Match r1 = reg.Match("Sausages");
//Match r2 = Regex.Match("Sausages", @"Sausages?");
//Match m1 = Regex.Match("One color? There are two colours in my head!", @"colou?rs?");
//Match m2 = m1.NextMatch();
//Console.WriteLine(m1);
//Console.WriteLine(m2);

//Console.WriteLine(Regex.IsMatch("jenny", "(?i)Jen(ny|nifer)?")); // Если отключить (?-i) добавляя -
//string html = "<i>By default</i> quantifiers are <i>greedy</i>creatures";
//foreach (Match m in Regex.Matches(html, @"<i>.*</i>")) // Линивый квантификатор Lazy   @"<i>.*?</i>
//    Console.WriteLine(m);

//Console.WriteLine(Regex.IsMatch("J Jenny,", @"\bJen(ny|nifer)?")); 


