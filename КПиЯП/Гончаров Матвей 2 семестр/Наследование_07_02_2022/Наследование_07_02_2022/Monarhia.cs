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

        public Monarhia(string name, string denezhnayaEden, string simvolika) : base(name, denezhnayaEden, simvolika)
        {
            this.vid = vid;
            this.nameMonarch = nameMonarch;
        }

        public override void UmenshKred_10(out int y)
        {
            Console.WriteLine($"out x: = {this.Kredit}");
            y = this.Kredit + 10;
            Console.WriteLine($"out x: = {y}");
        }

        public override void UvelichKred_10(ref int x)
        {
            Console.WriteLine($"До - kredit: = {x}");
            x += 10;
            Console.WriteLine($"После - kredit: = {x}");
            this.Kredit = x;
        }
    }
}
