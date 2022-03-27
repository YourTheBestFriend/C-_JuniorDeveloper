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
            ColoredConsole.WriteLine(ConsoleColor.Red, "2+2={0}", 4); // используется interpolation - Интерполяция
            ColoredConsole.WriteLine(ConsoleColor.Green, "просто зеленый текст");

            // 1.2 В данном случае есть несоответсвия - При выводе например слова Red - оно может быть зеленого цвета и т.д
//            Timer timerRed = new Timer(ClockTick1, null, 0, 200);  // 0 -первый старт, сразу начинается // 200 миллисекунд 
//            Timer timerGreen = new Timer(ClockTick2, null, 0, 200);
            Console.ReadLine(); // Для задержки после запуска таймера, можно заюзать еще Thread.Sleep
            /*
             Class Timer sealed - не наследуется
             
             это при запуске до поправки

             там был вопрос
             1. Я подумал это из-за конфликта вызова функции с одинаковым временем перезапуска - нет
             2. Из-за того что слишком мало времени - нет
             3. Посидев подумав я запустил каждый таймер по отдельности, и когда они работуют не вместе выяснил что когда Red всегда красный и Green всегда зеленый
             4. Попробовал запустить без передачи object o, даже не запустилось
             5. Потом я задался вопросом что же обозначет это вопросо object? state - если я правильно понял // width = house != null ? house.width : null ==== width = house?.width - работает как условный оператор, тип если house будет null  то house?.width будет null, если house не null то результат house?.width = house.width
             6. Думаю что проблема явно в том что они одновременно использую метод Write класса ColoredConsole, и из-за этого возникает конфликт т.к они работают в одном потоке?
             */


            // 1.3 Поправки в Class => ColoredConsole, после поправки действительно все стало отображаться как надо

            // 1.4 // class - System.Threading.Timer,
            Timer timerRed_2 = new Timer(ClockTick, ConsoleColor.Red, 0, 200); // 200 миллисекунд 
            Timer timerGreen_2 = new Timer(ClockTick, ConsoleColor.Green, 0, 200);
            Timer timerYellow = new Timer(ClockTick, ConsoleColor.Yellow, 0, 200);
            
            // // // link 2.2
            //Timer timer4 = new Timer(ClockTick, ConsoleColor.Blue, 0, 200);
            //Timer timer5 = new Timer(ClockTick, ConsoleColor.White, 0, 200);
            ////Timer timer6 = new Timer(ClockTick, ConsoleColor.Cyan, 0, 200);
            ////Timer timer7 = new Timer(ClockTick, ConsoleColor.Yellow, 0, 200);
            ////Timer timer8 = new Timer(ClockTick, ConsoleColor.Yellow, 0, 200);
            ////Timer timer9 = new Timer(ClockTick, ConsoleColor.Yellow, 0, 200);
            ////Timer timer10 = new Timer(ClockTick, ConsoleColor.Yellow, 0, 200);

            while (!Console.KeyAvailable) // Ждет пока не нажму на клавушу
            {
                Thread.Sleep(50);
                ColoredConsole.Write(ConsoleColor.Gray, ".");
            }

            // 2.1 Посмотреть диспетчер задач

            // 2.2 // только она начинает печатать с последнего
            /* 
                1. 5 ядер - добавил еще чтобы было 5 таймеров, последовательность сохраняется, но добавил 10 таймеров на 5 ядер происходит печать в произвольном порядке
                2. Я думаю что в одном потоке
             */

            // 2.3 число потоков в диспетчере значительно увеличелось

            // 2.4 потыкал в системном мониторе

            // 2.5 
        }

        // 1.2
        // в таймере эти методы запускаются каждые 200 миллисекунд
        // эти два метода передаются и являются - TimerCallback callback - delegate
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