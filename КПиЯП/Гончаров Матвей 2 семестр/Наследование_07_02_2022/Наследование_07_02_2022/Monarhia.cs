using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_07_02_2022
{
    internal class Monarhia : Gosudarstvo
    {
        string vid;
        string nameMonarch;

        public Monarhia(int x, string name, string denezhnayaEden, string simvolika) : base(x, name, denezhnayaEden, simvolika)
        {
            this.vid = vid;
            this.nameMonarch = nameMonarch;
        }


        public override void UmenshKred_10(out int x)
        {
            x += 10;
            Console.WriteLine($"x: = {x}");
        }

        public override void UvelichKred_10(ref int x)
        {
            x += 10;
            Console.WriteLine($"x: = {x}");
        }
    }
}
