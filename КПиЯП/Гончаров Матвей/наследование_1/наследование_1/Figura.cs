using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_1
{
    abstract class Figura
    {
        public double line { get; set; }
        public Figura() { }
        public Figura(double line) 
        {
            this.line = line;
        }
        public virtual void printSquare() { }

        public virtual void printVolume() { }
    }
}
