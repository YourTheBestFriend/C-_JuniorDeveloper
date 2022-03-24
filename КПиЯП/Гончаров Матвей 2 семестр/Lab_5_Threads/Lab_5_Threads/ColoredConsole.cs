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
    //        Console.Write(format, list);
    //    }
    //}
    // поправки 1.3
    public static class ColoredConsole
    {
        private static object locker = new object();
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
