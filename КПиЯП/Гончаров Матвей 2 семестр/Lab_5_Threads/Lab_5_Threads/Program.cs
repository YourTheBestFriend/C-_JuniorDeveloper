using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Threads
{
    class Program
    {
        public static void Main()
        {
            // 1.1 
            ColoredConsole.WriteLine(ConsoleColor.Red, "2+2={0}", 4);
            ColoredConsole.WriteLine(ConsoleColor.Green, "просто зеленый текст");

            // 1.2
            Timer timerRed = new Timer(ClockTick1, null, 0, 200);
            Timer timerGreen = new Timer(ClockTick2, null, 0, 200);
            Console.ReadLine();

            // 1.3 Поправки в Class => ColoredConsole

            // 1.4
            Timer timerRed_2 = new Timer(ClockTick, ConsoleColor.Red, 0, 200);
            Timer timerGreen_2 = new Timer(ClockTick, ConsoleColor.Green, 0, 200);
            Timer timerYellow = new Timer(ClockTick, ConsoleColor.Yellow, 0, 200);
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(50);
                ColoredConsole.Write(ConsoleColor.Gray, ".");
            }

            

        }

        // 1.2
        static void ClockTick1(object o)
        {
            ColoredConsole.Write(ConsoleColor.Red, "Red ");
        }
        static void ClockTick2(object o)
        {
            ColoredConsole.Write(ConsoleColor.Green, "Green ");
        }

        // 1.4
        static void ClockTick(object o)
        {
            ConsoleColor c = (ConsoleColor)o;
            ColoredConsole.Write(c, "{0} ", Thread.CurrentThread.ManagedThreadId);
        }
    }
}