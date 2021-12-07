using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfece_2711
{
    class Pramaugolnik : Figura, IComparable<Pramaugolnik>, IComparer<Pramaugolnik>
    {
        public double line2;
        public Pramaugolnik() { }
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
            Console.WriteLine($"Volume = {this.line * this.line2 * this.line}"); // Допустим последнее это высота
        }
        public override double getLine()
        {
            return this.line;
        }

        public int CompareTo(Pramaugolnik other)
        {
            return this.line.CompareTo(other.line);
        }

        public int Compare(Pramaugolnik x, Pramaugolnik y)
        {
            if (x.line > y.line)
                return 1;
            else if (x.line < y.line)
                return -1;
            else
                return 0;
        }
    }
}
