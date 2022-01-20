using System;

namespace okr
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Это первое было :I
            //int a;
            //for (a = 0; a < 9; a++)
            //{
            //    Console.WriteLine("Результат = " + (a+1)); // "Я лапух это сработает, я так и хотел напсать что от 1 до 9 сначала
            //}

            // 3
            Console.WriteLine("\nTask vector");
            Polozhitelgeometrvector obj1 = new Polozhitelgeometrvector(1,4);
            Polozhitelgeometrvector obj2 = new Polozhitelgeometrvector(5,3);

            Polozhitelgeometrvector obj3 = obj1 + obj2;
            Console.WriteLine($"Obj3: {obj3}");
            Polozhitelgeometrvector obj4 = obj1 * obj2;
            Console.WriteLine($"Obj4: {obj4}");
        }
    }
}
