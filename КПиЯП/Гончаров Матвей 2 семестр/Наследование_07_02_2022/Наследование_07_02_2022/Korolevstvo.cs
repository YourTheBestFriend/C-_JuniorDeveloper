using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_07_02_2022
{
    internal class Korolevstvo : Gosudarstvo
    {
        string korol;
        public Korolevstvo(string name, string denezhnayaEden, string simvolika, string korol) : base(name, denezhnayaEden, simvolika)
        {
            this.korol = korol;
        }

        //public override void UmenshKred_10(out int x)
        //{
        //    x += 10;
        //    Console.WriteLine($"x: = {x}");
        //}

        public override void UvelichKred_10(ref int x)
        {
            Console.WriteLine($"До - kredit: = {this.Kredit}");
            x += 10;
            Console.WriteLine($"После - kredit: = {this.Kredit}");
        }
    }
}
