using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_классы_вариант_6
{
    class Parallepiped : Body
    {
        private double LineB {get; set;}
        private double LineC {get; set;}
        public Parallepiped()
        {
            LineB = 1;
            LineC = 1;
            this.LineA = 1;
        }
        public Parallepiped(double lineA, double lineB, double lineC) : base(lineA)
        {
            this.LineB = lineB;
            this.LineC = lineC;
        }
        public override double CaleculateSquare()
        {
            // S = 2 (ab + ac + bc)
            return 2 * (this.LineA * LineB + this.LineA * LineC + LineB * LineC);
        }

        public override double CaleculateVolume()
        {
            // V = a*b*c
            return this.LineA * LineB * LineC;
        }
    }
}
