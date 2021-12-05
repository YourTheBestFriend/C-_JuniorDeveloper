using System;

namespace наследование_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Y obj1 = new Y(2.4, 8.3, 7.9);
            Console.WriteLine($"Equel = {obj1.Run()}");

            // task 2
            Console.WriteLine("\nKvadrat");
            Kvadrat obj2 = new Kvadrat(1.3);
            obj2.printSquare();
            obj2.printVolume();

            Console.WriteLine("\nPramaugolnic");
            Pramaugolnik obj3 = new Pramaugolnik(4.6, 8.3);
            obj3.printSquare();
            obj3.printVolume();
        }
    }
}
