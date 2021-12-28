using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_классы_вариант_6
{
    abstract class Body 
    {
        protected double lineA;
        public double LineA
        {
            get => lineA;
            set { lineA = value; }
        }
        public Body()
        {
            lineA = 1;
        }
        public Body(double lineA)
        {
            this.lineA = lineA;
        }
        public abstract double CaleculateSquare();
        public abstract double CaleculateVolume();
    }
}
