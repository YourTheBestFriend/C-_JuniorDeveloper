using System;

namespace oop_12_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person1 = new Person(); // Не смогу (т.к абстрактный класс не может иметь его объектов)
            Admin p1 = new Admin();
            p1.Name = "Matvey";
            p1.Age = 17;
            p1.WorkingMoreThanFiveYears = false;
            p1.MkServers = 5;
            p1.Speak("Привет, я делаю лабы - время 20:24 12.12.2021 Выздоравливайте :D");
            Console.WriteLine(p1);
        }
    }
}
