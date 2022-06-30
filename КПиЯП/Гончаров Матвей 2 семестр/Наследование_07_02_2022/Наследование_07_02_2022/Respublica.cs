using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_07_02_2022
{
    internal class Respublica : Gosudarstvo
    {
        static int numberObject = 0;
        string vid;
        string pravitelstvo;
        public static int NumberObject
        {
            get { return numberObject; }
            set { numberObject = value; }
        }
        public Respublica(string name, string denezhnayaEden, string simvolika, string vid, string pravitelstvo) : base(name, denezhnayaEden, simvolika)
        {
            NumberObject = ++NumberObject;
            this.vid = vid;
            this.pravitelstvo = pravitelstvo;
        }

        public override void UmenshKred_10(out int y)
        {
            Console.WriteLine($"out x: = {this.Kredit}");
            y = this.Kredit - 10;
            Console.WriteLine($"out x: = {y}");
        }

        public override void UvelichKred_10(ref int x)
        {
            Console.WriteLine($"До - kredit: = {x}");
            x += 10;
            Console.WriteLine($"После - kredit: = {x}");
            this.Kredit = x;
        }

        // статический метод вывода количества объектов
        public static void PrintColObject() => Console.WriteLine("num = " + NumberObject);
    }
}
