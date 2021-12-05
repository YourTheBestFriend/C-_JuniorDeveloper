using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfece_2711
{
    class Kvadrat : Figura
    {
        public Kvadrat(double line) : base(line)
        {
            // pass
        }

        public override void printSquare()
        {
            Console.WriteLine($"Square = {this.line * this.line}");
        }
        public override void printVolume()
        {
            Console.WriteLine($"Volume = {this.line * this.line * this.line}");
        }
        public override double getLine()
        {
            return this.line;
        }
    }
}
