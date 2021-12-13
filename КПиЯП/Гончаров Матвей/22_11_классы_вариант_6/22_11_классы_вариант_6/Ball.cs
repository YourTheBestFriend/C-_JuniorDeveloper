using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_классы_вариант_6
{
    class Ball : Body
    {
        public Ball()
        {
            this.LineA = 1; // Пусть тоже радиус
        }
        public Ball(double lineA) : base(lineA) { }
       
        public override double CaleculateSquare()
        {
            // S = 4*PI*R^2
            return 4 * PI * Pow(this.LineA, 2);
        }

        public override double CaleculateVolume()
        {
            // V = 4/3*PI*R^3
            return 4 / 3 * PI * Pow(this.LineA, 3);
        }
    }
}
