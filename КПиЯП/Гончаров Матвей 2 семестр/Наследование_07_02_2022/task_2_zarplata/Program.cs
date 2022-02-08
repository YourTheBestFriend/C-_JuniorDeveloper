/*
    1. Построить три класса (базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой (один из потомков) и фиксированной оплатой (второй потомок). +
    2. Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы. +
                Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 20.8 * 8 * почасовую ставку», +
                для работников с фиксированной оплатой «среднемесячная заработная плата = фиксированной месячной оплате». +

    3. упорядочить всю последовательность работников по убыванию среднемесячного заработка. При совпадении зарплаты – упорядочивать данные по алфавиту по имени. 
    4. Вывести идентификатор работника, имя и среднемесячный заработок для всех элементов списка; + all info
    5. вывести первые пять имен работников из упорядоченного списка; +
    6. вывести последние три идентификатора работников из упорядоченного списка. +
 */

namespace task_2_zarplata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // list
            List<Worker> listWorker = new List<Worker>();

            // member WorkerFixSalary
            WorkerFixSalary p1 = new WorkerFixSalary("Mattew", 1, 850.70);
            WorkerFixSalary p2 = new WorkerFixSalary("Artem", 2, 1200.95);
            WorkerFixSalary p3 = new WorkerFixSalary("David", 3, 900.10);

            // member WorkerOneHourSalary
            WorkerOneHourSalary p4 = new WorkerOneHourSalary("Gleb", 4, 60);
            WorkerOneHourSalary p5 = new WorkerOneHourSalary("Peta", 5, 30);
            WorkerOneHourSalary p6 = new WorkerOneHourSalary("Vasya", 6, 20);

            // Add 
            listWorker.Add(p1);
            listWorker.Add(p2);
            listWorker.Add(p3);
            listWorker.Add(p4);
            listWorker.Add(p5);
            listWorker.Add(p6);

            // Sort
            // Sort(listWorker);

            Console.WriteLine("All info:");
            for (int i = 0; i < listWorker.Count; i++)
            {
                Console.WriteLine($"listWorker[{i}] = " + listWorker[i]);
            }
            Console.WriteLine();
            // Первые 5 имен после сорта
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Name = " + listWorker[i].Name);
                }
            }
            catch (Exception)
            {
                //  throw;
            }

            // Последние 3 id после сорта
            try
            {
                for (int i = listWorker.Count; i > listWorker.Count-2; i--)
                {
                    Console.WriteLine("Id = " + listWorker[i].Id);
                }
            }
            catch (Exception)
            {
                // throw;
            }

        }
    }
}