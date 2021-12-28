using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_классы_вариант_6
{
    class Cone : Body
    {
        private double Linel { get; set; }
        private double LineH { get; set; }
        public Cone()
        {
            Linel = 1;
            LineH = 1;
            this.LineA = 1; // Пусть это будет радиус
        }
        public Cone(double lineA, double linel, double lineH) : base(lineA)
        {
            this.Linel = linel;
            this.LineH = lineH;
        }
        public override double CaleculateSquare()
        {
            // S = pi*r*(r+l)    l - образующая
            return PI*this.LineA*(this.LineA+Linel);
        }

        public override double CaleculateVolume()
        {
            // V = 1/3 * S * h
            return 1.0/3 * CaleculateSquare() * LineH;
        }
    }
}
