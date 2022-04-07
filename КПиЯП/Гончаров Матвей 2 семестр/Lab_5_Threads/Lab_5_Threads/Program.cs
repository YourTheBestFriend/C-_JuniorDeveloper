using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Threads
{
    class Program
    {
        public static int Million100 { get; set; } // for task 3.1
        private static object locker = new object(); // for task 3.2
        static Semaphore semafor; // for 3.5
        static Mutex mutex; // 3.4
        static Mutex mutexA = new Mutex(false); // 4.2
        static Mutex mutexB = new Mutex(false); // 4.2 

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

        // 2.5
        static void JustAThread(object o)
        {
            int n = (int)o;
            if (n > 15 || n < 1) // недопустимые номера выводить белым цветом
            {
                n = 15;
            }
            while (true)
            {
                Thread.Sleep(1000);
                ColoredConsole.Write((ConsoleColor)n, "{0} ", Thread.CurrentThread.ManagedThreadId);
            }
        }

        // 3.3 
        static void SecondWork(object o)
        {
            Random rnd = new Random();
            int sec = rnd.Next(4) + 2;
            string name = Thread.CurrentThread.Name;
            if (String.IsNullOrEmpty(name))
                name = "NoName";
            ColoredConsole.WriteLine(ConsoleColor.Green, "Поток {0} запущен", name);
            for (int k = 0; k < sec - 1; ++k)
            {
                Thread.Sleep(1000);
                ColoredConsole.WriteLine(ConsoleColor.Yellow, "Поток {0} работает", name);
            }
            ColoredConsole.WriteLine(ConsoleColor.Red, "Поток {0} завершен", name);
            AutoResetEvent ev = (AutoResetEvent)o;
            ev.Set();
        }

        // 3.4 with Mutex
        static void SecondWork_2()
        {
            Random rnd = new Random();
            int sec = rnd.Next(4) + 2;
            string name = Thread.CurrentThread.Name;
            if (String.IsNullOrEmpty(name))
                name = "NoName";
            mutex.WaitOne();
            ColoredConsole.WriteLine(ConsoleColor.Green, "Поток {0} запущен", name);
            for (int k = 0; k < sec - 1; ++k)
            {
                Thread.Sleep(1000);
                ColoredConsole.WriteLine(ConsoleColor.Yellow, "Поток {0} работает", name);
            }
            ColoredConsole.WriteLine(ConsoleColor.Red, "Поток {0} завершен", name);
            mutex.ReleaseMutex();
        }
        // 3.5
        static void SecondWork_3()
        {
            Random rnd = new Random();
            int sec = rnd.Next(4) + 2;
            string name = Thread.CurrentThread.Name;
            if (String.IsNullOrEmpty(name))
                name = "NoName";
            semafor.WaitOne();
            ColoredConsole.WriteLine(ConsoleColor.Green, "Поток {0} запущен", name);

            for (int k = 0; k < sec - 1; ++k)
            {
                Thread.Sleep(1000);
                ColoredConsole.WriteLine(ConsoleColor.Yellow, "Поток {0} работает", name);
            }
            ColoredConsole.WriteLine(ConsoleColor.Red, "Поток {0} завершен", name);
            semafor.Release();
        }

        // 4.1
        static void SillyWork()
        {
            ColoredConsole.WriteLine(ConsoleColor.Green, "Task {0} started", Task.CurrentId);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Yellow, "Task {0} worked", Task.CurrentId);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Red, "Task {0} finished", Task.CurrentId);
        }

        //////////////////////// 4.2
        static void SillyWork_()
        {
            mutexA.WaitOne();
            ColoredConsole.WriteLine(ConsoleColor.Green, "Task {0} started", Task.CurrentId);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Yellow, "Task {0} worked", Task.CurrentId);
            Thread.Sleep(1000);
            mutexB.WaitOne();
            ColoredConsole.WriteLine(ConsoleColor.Red, "Task {0} finished", Task.CurrentId);
            mutexA.ReleaseMutex();
            mutexB.ReleaseMutex();
        }
        static void SillyWork2_()
        {
            mutexB.WaitOne();
            ColoredConsole.WriteLine(ConsoleColor.Green, "Task {0} started", Task.CurrentId);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Yellow, "Task {0} worked", Task.CurrentId);
            Thread.Sleep(1000);
            mutexA.WaitOne();
            ColoredConsole.WriteLine(ConsoleColor.Red, "Task {0} finished", Task.CurrentId);
            mutexB.ReleaseMutex();
            mutexA.ReleaseMutex();
        }

        /////////////////////////// 4.3
        static void SillyWork__()
        {
            ColoredConsole.WriteLine(ConsoleColor.Green, "Task {0} started", Task.CurrentId);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Yellow, "Task {0} worked", Task.CurrentId);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Red, "Task {0} finished", Task.CurrentId);
        }
        static void NextSillyWork(Task t)
        {
            ColoredConsole.WriteLine(ConsoleColor.Green, "Task {0} started after task {1}",
            Task.CurrentId, t.Id);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Yellow, "Task {0} worked", Task.CurrentId);
            Thread.Sleep(1000);
            ColoredConsole.WriteLine(ConsoleColor.Red, "Task {0} finished", Task.CurrentId);
        }

        ///////////////////////////////////// 5.1
        public static string Translate(string source)
        {
            ColoredConsole.WriteLine(ConsoleColor.Green, "Translate started ");
            String template = " " + source + " ";
            String res = "";
            using (FileStream fs = File.OpenRead(@"C:\Users\shindows10\Desktop\C-_JuniorDeveloper\КПиЯП\Гончаров Матвей 2 семестр\Lab_5_Threads\Lab_5_Threads\mueller1995.txt"))
            using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(1251)))
            {
                Boolean found = false;
                Boolean finished = false;

                String line;
                while ((!found || !finished) && ((line = sr.ReadLine()) != null))
                {
                    if (found)
                    {
                        if (line != "" && line[0] != ' ') // продолжение словарной статьи
                            res += line;
                        else // начало новой словарной статьи
                            finished = true;
                    }
                    else
                    if (line != "" && line[0] == ' ')
                    {
                        int n = line.IndexOf(template);
                        if (n > 0 && n < 20) // ищем слово только в определении
                        {
                            res += line;
                            found = true;
                        }
                    }
                }
            }
            ColoredConsole.WriteLine(ConsoleColor.Green, "Translate finished");
            return res;
        }
        delegate String StringToString(String s);


        /// 5.4 
        //public static async Task<String> TranslateUpperAsync(String s)
        //{
        //    ColoredConsole.WriteLine(ConsoleColor.Magenta, "TranslateUpperAsync started "
        //    + "in Task {0}", Task.CurrentId);
        //    Thread.Sleep(1000);
        //    String Z = await TranslateAsync(s);
        //    ColoredConsole.WriteLine(ConsoleColor.Magenta, "{0} (Task {1})", Z, Task.CurrentId);
        //    return Z.ToUpper();
        //}

        public static void Main()
        {
            // 1.1 
            ColoredConsole.WriteLine(ConsoleColor.Red, "2+2={0}", 4); // используется interpolation - Интерполяция
            ColoredConsole.WriteLine(ConsoleColor.Green, "просто зеленый текст");

            // 1.2 В данном случае есть несоответсвия - При выводе например слова Red - оно может быть зеленого цвета и т.д
            //            Timer timerRed = new Timer(ClockTick1, null, 0, 200);  // 0 - первый старт, сразу начинается // 200 миллисекунд 
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
             6. Думаю что проблема явно в том что они одновременно использую метод Write класса ColoredConsole, и из-за этого возникает конфликт т.к они работают в одном потоке? - в плане как main один поток
             */


            // 1.3 Поправки в Class => ColoredConsole, после поправки действительно все стало отображаться как надо

            // 1.4 // class - System.Threading.Timer,
            /*            Timer timerRed_2 = new Timer(ClockTick, ConsoleColor.Red, 0, 200); // 200 миллисекунд 
                        Timer timerGreen_2 = new Timer(ClockTick, ConsoleColor.Green, 0, 200);
                        Timer timerYellow = new Timer(ClockTick, ConsoleColor.Yellow, 0, 200);

                        // link 2.2
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
            */
            // 2.1 Посмотреть диспетчер задач

            // 2.2 // только она начинает печатать с последнего
            /* 
                1. 5 ядер - добавил еще чтобы было 5 таймеров, последовательность сохраняется, но добавил 10 таймеров на 5 ядер происходит печать в произвольном порядке
                2. Я думаю что в одном потоке
             */

            // 2.3
            /*
                при запуске 3 - 17 потоков, 
                при 10 - 20, 21
             */


            // 2.4 потыкал в системном мониторе

            // 2.5 
            /*            for (int i = 1; i < 16; ++i)
                        {
                            Thread t = new Thread(JustAThread);
                            ///////////////////////////////////////////////////// 2.7
                            t.IsBackground = true;
                            switch (i)
                            {
                                case 1: case 9:
                                    t.Priority = ThreadPriority.Lowest;
                                    break;
                                case 2: case 10:
                                    t.Priority = ThreadPriority.Highest;
                                    break;
                            }
                            ///////////////////////////////////////////////////// 2.7
                            t.Start(i);
                            //Thread.Sleep(3000); // 2.6
                        }
                        while (!Console.KeyAvailable)
                        {
                            Thread.Sleep(50);
                            ColoredConsole.Write(ConsoleColor.Gray, ".");
                        }
            */
            /*
             1. номер потока не изменяется и у него остается свой цвет
             2. порядок не постоянный
             3. программу не остановишь, - если нажму клавишу то прекратится цикл где печатаю точки, - метод JustAThread() - будет дальше работать - т.к там while бесконечно будет бежать
             4. Всмысле нет, программу по клавише не остановить, хотя -- а что если alt+f4
             */

            // 2.6 Thread.Sleep(3000);

            // 2.7
            /*
             1. Да теперь можно остановить по нажатию клавиши
             2. потоков стало больше и график стал выше
             */



            ///////////////// 3  Синхронизация доступа к ресурсам

            // 3.1
            /*
                        for (int i = 0; i < 20; ++i)
                        {
                            Thread t = new Thread(() => { lock (locker) for (int k = 0; k < 5000000; ++k)  Million100++; }); // 3.2 locker
                            t.IsBackground = true;
                            t.Start();
                        }
                        while (!Console.KeyAvailable)
                        {
                            Thread.Sleep(50);
                            ColoredConsole.WriteLine(ConsoleColor.Gray, "{0}", Million100);
                        }
                        // до ста миллионов не дошло --- у меня вывод 23151875, ну если поставить не 20 а 95 переваливает за сто миллионов, типс помощью увеличения фоновых потоков
             */
            // 3.2 - с locker все дошло как надо, да т если раньше поставить то значительнее быстрее

            // 3.3
            /*            Thread[] threads = new Thread[3];
                        AutoResetEvent[] waitEvents = new AutoResetEvent[3];
                        String[] names = { "A", " B", " C" };
                        for (int i = 0; i < 3; ++i)
                        {
                            waitEvents[i] = new AutoResetEvent(false);
                            threads[i] = new Thread(SecondWork);
                            threads[i].Name = names[i];
                            threads[i].Start(waitEvents[i]);
                        }
                        ColoredConsole.WriteLine(ConsoleColor.White, "Основной поток ожидает окончания работы потоков");
                        AutoResetEvent.WaitAll(waitEvents);
                        ColoredConsole.WriteLine(ConsoleColor.White, "Основной поток дождался окончания работы потоков");
            */

            // 3.4 - Mutex
            /*          Thread[] threads = new Thread[3];
                        String[] names = { "A", " B", " C" };
                        mutex = new Mutex(false);
                        for (int i = 0; i < 3; ++i)
                        {
                            threads[i] = new Thread(new ThreadStart(SecondWork_2));
                            threads[i].Name = names[i];
                            threads[i].Start();
                        }
            */

            // 3.5
            /*           Thread[] threads = new Thread[3];
                       String[] names = { "A", " B", " C" };
                       semafor = new Semaphore(2, 2);
                       for (int i = 0; i < 3; ++i)
                       {
                           threads[i] = new Thread(new ThreadStart(SecondWork_3));
                           threads[i].Name = names[i];
                           threads[i].Start();
                       }
           */

            // 4.1 // выведет состояние потоков по 3
            /*          Task t1 = new Task(SillyWork);
                        Task t2 = new Task(SillyWork);
                        Task t3 = new Task(SillyWork);
                        t1.Start();
                        t2.Start();
                        t3.Start();
                        while (!Console.KeyAvailable)
                        {
                            Thread.Sleep(50);
                            ColoredConsole.Write(ConsoleColor.Gray, ".");
                        }
            */
            // 4.2 // заморозка двух потоков
            /*           Task t1 = new Task(SillyWork_);
                       Task t2 = new Task(SillyWork2_);
                       t1.Start();
                       t2.Start();
                       while (!Console.KeyAvailable)
                       {
                           Thread.Sleep(50);
                           ColoredConsole.Write(ConsoleColor.Gray, ".");
                       }
            */

            // 4.3 
            /*            Task t1 = new Task(SillyWork);
                        Task t2 = t1.ContinueWith(NextSillyWork);
                        Task t3 = t2.ContinueWith(NextSillyWork);
                        t1.Start();
                        while (!Console.KeyAvailable)
                        {
                            Thread.Sleep(50);
                            ColoredConsole.Write(ConsoleColor.Gray, ".");
                        }
            */

            ////////////////////// 5 Асинхронное выполнение методов /////  ТУТ траблы
            //  я там наверное в файле не правильно пишу
            // 5.1
            /*
                        (new Task(() => {
                            while (!Console.KeyAvailable)
                            {
                                Thread.Sleep(50);

                                ColoredConsole.Write(ConsoleColor.Gray, ".");

                            }
                        })).Start();
                        StringToString d = new StringToString(Translate);
                        String Z = d.Invoke("zoological");
                        ColoredConsole.WriteLine(ConsoleColor.Red, Z);
            */
            // 5.2
            /*
                        StringToString d = new StringToString(Translate);
                        IAsyncResult ar = d.BeginInvoke("zoological", null, null);
                        while (!ar.IsCompleted)
                        {
                            ColoredConsole.Write(ConsoleColor.Red, "-");
                            Thread.Sleep(50);
                        }
                        ColoredConsole.WriteLine(ConsoleColor.Red, "{0}", d.EndInvoke(ar));
            */

            /*
                        // 5.3
                        Task<String> t = TranslateAsync("zebra");
                        while (!t.IsCompleted)
                        {
                            ColoredConsole.Write(ConsoleColor.Red, "-");
                            Thread.Sleep(50);
                        }
                        ColoredConsole.WriteLine(ConsoleColor.Red, "{0}", t.Result);
            */

            // 5.4
            /*
                        (new Task(() => {
                            while (!Console.KeyAvailable)
                            {
                                Thread.Sleep(50);
                                ColoredConsole.Write(ConsoleColor.Gray, ".");
                            }
                        })).Start();
                        ColoredConsole.WriteLine(ConsoleColor.Red, "{0} (Task {1})",
                        TranslateUpperAsync("yelp").GetAwaiter().GetResult(), Task.CurrentId);
            */

            /////////////////////////////////////////////////////////////////////////// Упражнение 6
            // 6.1
/*
            Assembly assembly = Assembly.LoadFrom(@"D:\cs\BlackBox.dll");
            Console.WriteLine("***Список типов***");
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            Console.WriteLine(t.FullName);
*/
            // 6.2
/*
            Console.WriteLine("***Список конструкторов***");
            ConstructorInfo[] ctors = type.GetConstructors();
            foreach (ConstructorInfo c in ctors)
            {
                Console.WriteLine(c);
                Console.WriteLine("Имя: " + c.Name);
                ParameterInfo[] param = c.GetParameters();
                foreach (ParameterInfo pi in param)
                    Console.WriteLine(" {0}", pi);
            }
*/
            // 6.3
/*
            Console.WriteLine("***Список методов***");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo mi in methods)
            {
                Console.WriteLine(mi);
                ParameterInfo[] param = mi.GetParameters();
                foreach (ParameterInfo pi in param)
                    Console.WriteLine(" {0}", pi);
            }
*/
            // 6.4
/*
            ConstructorInfo ctor = ctors[0];
            MethodInfo method = methods[0];
            Console.WriteLine(method);
            Console.WriteLine("***Создание объекта***");
            object o = ctor.Invoke(new object[] { 3.0, 4.0 });
            Console.WriteLine("***Вызов метода***");
            Double result = (Double)method.Invoke(o, new object[0]);
            Console.WriteLine("Результат выполнения метода: " + result.ToString("F2"));
*/
            // 6.5
/*
            Console.WriteLine("***Список полей класса Decorated***");
            Type typeD = assembly.GetType("BlackBox.Decorated");
            Console.WriteLine(typeD.FullName);
            FieldInfo[] fields = typeD.GetFields();
            foreach (FieldInfo field in fields)
            {
                var attributes = field.GetCustomAttributes();
                foreach (Attribute a in attributes)
                {
                    String s = a.ToString();
                    int n = s.IndexOf("Attribute");
                    if (n > 0)
                        s = s.Substring(0, n);
                    Console.Write(s + " ");
                }
                Console.WriteLine(field.Name);
            }
*/
        }
    } 
}