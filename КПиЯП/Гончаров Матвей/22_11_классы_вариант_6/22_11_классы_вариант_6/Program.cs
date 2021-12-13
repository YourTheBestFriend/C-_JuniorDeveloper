using System;
//using System.IO; // for working with files
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_классы_вариант_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // parallepiped
            Parallepiped p1 = new Parallepiped(10, 12, 14);
            Parallepiped p2 = new Parallepiped(11, 9, 20);
            List<Parallepiped> ls_1 = new List<Parallepiped>();
            ls_1.Add(p1);
            ls_1.Add(p2);

            // cone
            Cone c1 = new Cone(8, 12, 14);
            Cone c2 = new Cone(21, 23, 20);
            List<Cone> ls_2 = new List<Cone>();
            ls_2.Add(c1);
            ls_2.Add(c2);

            // ball
            Ball b1 = new Ball(5);
            Ball b2 = new Ball(7);
            List<Ball> ls_3 = new List<Ball>();
            ls_3.Add(b1);
            ls_3.Add(b2);

            // Создал тот самый список
            Series sr1 = new Series(ls_1, ls_2, ls_3);
            sr1.Display();

            // Вычисление S and V and Sort
            Console.WriteLine("\n=====1=====");
            for (int i = 0; i < sr1.ListParalip.Count; i++)
            {
                Console.WriteLine($"ListParalip[{i}]: S = {sr1.ListParalip[i].CaleculateSquare()}, V = {sr1.ListParalip[i].CaleculateVolume()}");
                //sr1.ListParalip.Sort();
            }
            Console.WriteLine("\n=====2=====");
            for (int i = 0; i < sr1.ListCone.Count; i++)
            {
                Console.WriteLine($"ListCone[{i}]: S = {sr1.ListCone[i].CaleculateSquare()}, V = {sr1.ListCone[i].CaleculateVolume()}");
                //sr1.ListCone.Sort();
            }
            Console.WriteLine("\n=====3=====");
            for (int i = 0; i < sr1.ListBall.Count; i++)
            {
                Console.WriteLine($"ListBall[{i}]: S = {sr1.ListBall[i].CaleculateSquare()}, V = {sr1.ListBall[i].CaleculateVolume()}");
                //sr1.ListBall.Sort();
            }
            //Console.WriteLine("\nПосле сортировки");
            //sr1.Display();
        }
    }
}
