using System;

namespace interfece_2711
{
    class Program
    {
        static void Main(string[] args)
        {
            //// task 1
            //Console.WriteLine("/////////////////////// Task 1");
            //Console.WriteLine("\nbankomat1");
            //// Создаю первый банкомат
            //BankomatPrior bankomat1 = new BankomatPrior(1, 26.3);
            //bankomat1.snatDengi(23.6);
            //bankomat1.getBonus();

            //// Явная реализация
            //Console.WriteLine("\nbankomat2");
            //Ibankomat bankomat2 = new BankomatPrior(2, 50.4); // По такому приколу можно и методы крутить в классе Ibankomat.snatDengi(x);
            //bankomat2.snatDengi(10.6);

            //Console.WriteLine("\nbankomat3");
            //IbankomatPriorbank bankomat3 = new BankomatPrior(3, 10.3);
            //bankomat3.getBonus();

            // task 2
            //Console.WriteLine("\nTask 2");

            Console.WriteLine("\nKvadrat");
            Kvadrat obj1 = new Kvadrat(4.5);
            obj1.printSquare();
            (obj1 as ISquare).printSquare();
            obj1.printVolume();

            Console.WriteLine("\nPramaugolnic");
            Pramaugolnik obj2 = new Pramaugolnik(3.4, 7.5);
            obj2.printSquare();
            obj2.printVolume();

            //// task 3 
            //Console.WriteLine("\n/////////////////////// Task 3");
            //Pramaugolnik pr1 = new Pramaugolnik(10, 12);
            //Pramaugolnik pr2 = new Pramaugolnik(4, 22);
            //Pramaugolnik pr3 = new Pramaugolnik(1, 42);

            //Class_Task3 cl = new Class_Task3(pr1, pr2, pr3);
            //Console.WriteLine("\n[with IComparable]\nFirst check list");
            //// make cl
            //cl.printForeachList();
            //cl.Add(new Pramaugolnik(3, 3));
            //// clone
            //Class_Task3 cl_clone = cl.Clone() as Class_Task3;
            //Console.WriteLine("\n//////clone");
            //cl_clone.printForeachList();
            //Console.WriteLine("-----original-----");
            //cl.printForeachList();
            //// sort cl
            //cl.sortListPramaugolnik();
            //Console.WriteLine("sort____list");
            //cl.printForeachList();

            //Console.WriteLine("\n[with IComparer]\nFirst check list");
            //Class_Task3 cl_2 = new Class_Task3(pr1, pr2, pr3);
            //cl_2.printForeachList();
            //cl_2.sortListPramaugolnik2();
            //Console.WriteLine("sort____list");
            //cl_2.printForeachList();

            //// print 
            //Console.WriteLine("\n[with IEnumerable]");
            //// cl.printForeachList();
            //foreach (var item in cl)
            //{
            //    Console.WriteLine($"({item.line},{item.line2})");
            //}

        }
    }
}
