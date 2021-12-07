using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfece_2711
{
    abstract class Figura : ISquare, IVolume
    {
        public double line;
        public Figura() { }
        public Figura(double line) 
        {
            this.line = line;
        }
        public abstract void printSquare();

        public abstract void printVolume();

        public abstract double getLine();

    }
}
