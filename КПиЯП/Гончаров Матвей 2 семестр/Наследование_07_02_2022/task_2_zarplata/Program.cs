/*
    1. Построить три класса (базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой (один из потомков) и фиксированной оплатой (второй потомок). +
    2. Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы. +
                Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 20.8 * 8 * почасовую ставку», +
                для работников с фиксированной оплатой «среднемесячная заработная плата = фиксированной месячной оплате». +

    3. упорядочить всю последовательность работников по убыванию среднемесячного заработка. При совпадении зарплаты – упорядочивать данные по алфавиту по имени. +
    4. Вывести идентификатор работника, имя и среднемесячный заработок для всех элементов списка; + all info
    5. вывести первые пять имен работников из упорядоченного списка; +
    6. вывести последние три идентификатора работников из упорядоченного списка. +
 */
using System.Collections.Generic;
namespace task_2_zarplata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // list
            List<Worker> listWorker = new List<Worker>();

            // member WorkerFixSalary
            //WorkerFixSalary p1 = new WorkerFixSalary("Mattew", 1, 850.70);
            //WorkerFixSalary p2 = new WorkerFixSalary("Artem", 2, 1200.95);
            //WorkerFixSalary p3 = new WorkerFixSalary("David", 3, 900.10);
            // Для теста сортирует ли по алфавиту
            WorkerFixSalary p1 = new WorkerFixSalary("Mattew", 1, 10);
            WorkerFixSalary p2 = new WorkerFixSalary("Artem", 2, 10);
            WorkerFixSalary p3 = new WorkerFixSalary("David", 3, 20);
            WorkerFixSalary p33 = new WorkerFixSalary("David", 3, 15);

            // member WorkerOneHourSalary
            WorkerOneHourSalary p4 = new WorkerOneHourSalary("Gleb", 4, 60);
            WorkerOneHourSalary p5 = new WorkerOneHourSalary("Peta", 5, 2);
            WorkerOneHourSalary p6 = new WorkerOneHourSalary("Vasya", 6, 20);

            // Add 
            listWorker.Add(p1);
            listWorker.Add(p2);
            listWorker.Add(p3);
            listWorker.Add(p4);
            listWorker.Add(p5);
            listWorker.Add(p6);
            listWorker.Add(p33);

            Console.WriteLine("All info До сортировки:");
            for (int i = 0; i < listWorker.Count; i++)
            {
                Console.WriteLine($"listWorker[{i}] = " + listWorker[i]);
            }
            Console.WriteLine("_____________");
            Console.WriteLine();
            listWorker.Sort(); // Сортанет
            
            foreach (var item in listWorker)
            {
                Console.WriteLine($"{item.Name,15} {item.returnSalary(),10:f2}");
            }
            Console.WriteLine("_____________\n");
            Console.WriteLine("All info После сортировки:");
            for (int i = 0; i < listWorker.Count; i++)
            {
                Console.WriteLine($"listWorker[{i}] = " + listWorker[i]);
            }
            Console.WriteLine();
            // Первые 5 имен после сорта
            Console.WriteLine("Первые 5 имен после сорта");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Name = " + listWorker[i].Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            // Последние 3 id после сорта
            Console.WriteLine("Последние 3 id после сорта");
            try
            {
                for (int i = listWorker.Count-1; i > listWorker.Count-4; i--)
                {
                    Console.WriteLine("Id = " + listWorker[i].Id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}