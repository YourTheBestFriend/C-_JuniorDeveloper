using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesobitia
{
    class Program
    {
        // 1
        delegate void DelegateFirst(double start, double end, double step);
        public static void PrintFunk(double start, double end, double step)
        {
            for (double i = start; i <= end; i += step)
            {
                Console.WriteLine($"Asin({i}) = {Asin(i)} | Atan({i}) = {Atan(i)}");
            }
            Console.WriteLine();
        }

        // 2
        delegate void DelegateSecond(int p); // p - выбор по какому элементу сортировать

        // 3
        delegate string Name(string[] mas);

        // functions for 5 task 
        private static void RightMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void FalseMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        // 6
        public delegate double del(double x, double y);

        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("Task 1");
            DelegateFirst dg1;
            dg1 = PrintFunk;
            dg1(-1, 1, 0.2);

            // Task 2
            Console.WriteLine("Task 2");
            // книги
            Book bk1 = new Book("UNIX and LINUX", "EVI NEMET", 5);
            Book bk2 = new Book("Computer Networks", "Victor Olifer", 2);
            Book bk3 = new Book("Automatization on Python", "El Sveigard", 7);
            Book bk4 = new Book("Powershell", "Adam Bertram", 1);
            Book bk5 = new Book("Bash and Cyber Secure", "Poll Tronkon", 3);
            
            // Для примера наполнил список книг
            List<Book> ls_Book = new List<Book> { bk1, bk2, bk3, bk4, bk5};
            
            // Класс в котором список этих книг
            ConteinerBook listBook = new ConteinerBook(ls_Book);
            Console.WriteLine("ДО изминений");
            listBook.PrintAllData();

            DelegateSecond dg2;
            dg2 = listBook.SortListBook;

            // Работает только по изданию
            dg2(1); // Сортировка по Названию
            // dg2(2); // Сортировка по Автору
            // dg2(3); // Сортировка по изданию

            Console.WriteLine("После изминений");
            listBook.PrintAllData();

            // 3
            Console.WriteLine("\nTask 3");
            string[] mas = new string[] { "Гончаров", "Матвей", "Николаевич" };
            Task3 person1 = new Task3();
            Name n1 = person1.FullName;
            Console.WriteLine(n1(mas));
            Name n2 = person1.Name;
            Console.WriteLine(n2(mas));

            // 4
            Console.WriteLine("\nTask 4");
            Computer c = new Computer();
            c.Notify += RightMessage;
            c.Push("Double click");

            // 5
            Console.WriteLine("\nTask 5");
            NewsOperator n = new NewsOperator();
            ServiceSubscriber s = new ServiceSubscriber(n);
            n.OnAddNew += RightMessage;
            s.OnAlreadySigned += FalseMessage;
            s.OnSubscribe += RightMessage;
            s.OnInvalid += FalseMessage;

            ServiceSubscriber s2 = new ServiceSubscriber(n);
            n.OnAddNew += RightMessage;
            s2.OnAlreadySigned += FalseMessage;
            s2.OnSubscribe += RightMessage;
            s2.OnInvalid += FalseMessage;

            s.Subscribe();
            //Console.WriteLine("___");
            s2.Subscribe();
            
            n.AddWeather("0 градусов");
            n.AddSport("Хоккей в 7:00");
            n.AddIncident("Землетрясение");

            // 6
            Console.WriteLine("\nTask 6");
            try
            {
                Calculator calc = new Calculator();
                del deleg = new del(calc.Summ);
                Console.WriteLine(deleg(2, 500));
                deleg += delegate (double x, double y) { return x - y; };
                Console.WriteLine(deleg(12, 2));
                deleg += (double x, double y) => x * y;
                Console.WriteLine(deleg(56, 12));
                Console.WriteLine(calc.Multiplication(2, 11));
                Console.WriteLine(calc.Division(5, 3));
                Console.WriteLine(calc.Degree(6, 8));
                Console.WriteLine(calc.Square(40));
                Console.WriteLine(calc.Division(1, 0));
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
