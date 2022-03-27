using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Threads
{
    // Task 1
    //public static class ColoredConsole
    //{
    //    private static object locker = new object();
    //    public static void WriteLine(ConsoleColor color, String format, params object[] list)
    //    {
    //        Console.ForegroundColor = color;
    //        Console.WriteLine(format, list);
    //    }
    //    public static void Write(ConsoleColor color, String format, params object[] list)
    //    {
    //        Console.ForegroundColor = color;
    //        Console.Write(format, list); // Это обычный метод для печати без перехода на новую строку - а то я сразу глянул, подумал рекурсия)
    //    }
    //}
    // поправки 1.3
    public static class ColoredConsole
    {
        /*
         Оператор lock получает взаимоисключающую блокировку заданного объекта 
         перед выполнением определенных операторов, а затем снимает блокировку. 
         Во время блокировки поток, удерживающий блокировку, может снова поставить
         и снять блокировку. Любой другой поток не может получить блокировку и ожидает ее 
         снятия.
         */

        private static object locker = new object(); // Сам наш объект блокировки
        // Цвет, строка, любое кол-во объектов которое может встать в строку (можно не только число), python --- 'Hello my friend {0}, I'm {1} years old!'.format("Matthew", 17)
        public static void WriteLine(ConsoleColor color, String format, params object[] list)
        {
            lock (locker)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(format, list);
            }
        }
        public static void Write(ConsoleColor color, String format, params object[] list)
        {
            lock (locker)
            {
                Console.ForegroundColor = color;
                Console.Write(format, list);
            }
        }
    }
}
