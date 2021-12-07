using System;

namespace interfece_2711
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine("/////////////////////// Task 1");
            Console.WriteLine("\nbankomat1");
            // Создаю первый банкомат
            BankomatPrior bankomat1 = new BankomatPrior(1, 26.3);
            bankomat1.snatDengi(23.6);
            bankomat1.getBonus();

            // Явная реализация
            Console.WriteLine("\nbankomat2");
            Ibankomat bankomat2 = new BankomatPrior(2, 50.4); // По такому приколу можно и методы крутить в классе Ibankomat.snatDengi(x);
            bankomat2.snatDengi(10.6);

            Console.WriteLine("\nbankomat3");
            IbankomatPriorbank bankomat3 = new BankomatPrior(3, 10.3);
            bankomat3.getBonus();

            // task 2
            Console.WriteLine("\n/////////////////////// Task 2");

            Console.WriteLine("\nKvadrat");
            Kvadrat obj1 = new Kvadrat(4.5);
            obj1.printSquare();
            (obj1 as ISquare).printSquare();
            obj1.printVolume();

            Console.WriteLine("\nPramaugolnic");
            Pramaugolnik obj2 = new Pramaugolnik(3.4, 7.5);
            obj2.printSquare();
            obj2.printVolume();

            // task 3 

            
        }
    }
}
