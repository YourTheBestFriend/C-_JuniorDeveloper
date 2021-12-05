using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_1
{
    class Y : X
    {
        public double y { get; set; }
        public Y(double x1, double x2, double y) : base(x1, x2)
        {
            this.y = y;
        }
        public double getX1()
        {
            return this.x1;
        }
        public double getX2()
        {
            return this.x2;
        }
        public void setX1(double x1)
        {
            this.x1 = x1;
        }
        public void setX2(double x2)
        {
            this.x2 = x2;
        }
        public double Run()
        {
            return (this.x1 + this.x2) * this.y;
        }
    }
}
