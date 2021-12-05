using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_1
{
    class Pramaugolnik : Figura
    {
        public double line2;
        public Pramaugolnik(double line, double line2) : base(line)
        {
            this.line2 = line2;
        }
        public override void printSquare()
        {
            Console.WriteLine($"Square = {this.line + this.line2}");
        }
        public override void printVolume()
        {
            Console.WriteLine($"Volume = {this.line * this.line2 * this.line}");  // Допустим последнее это высота
        }
       
    }
}
