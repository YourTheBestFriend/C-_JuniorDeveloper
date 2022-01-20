using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okr
{
    class Polozhitelgeometrvector
    {
        private int x;
        private int y;

        public int X
        {
            get => x;
            set 
            {
                if (x > -1)
                {
                    x = value;
                }
                else
                {
                    throw new Exception("Координаты должны быть строго положительными");
                }
            }
        }
        public int Y
        {
            get => y;
            set
            {
                if (y > -1)
                {
                   y = value;
                }
                else
                {
                    throw new Exception("Координаты должны быть строго положительными");
                }
            }
        }
        public Polozhitelgeometrvector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Polozhitelgeometrvector operator+(Polozhitelgeometrvector obj1, Polozhitelgeometrvector obj2)
        {
            return new Polozhitelgeometrvector(obj1.X + obj2.X, obj1.Y + obj2.Y);
        }
        public static Polozhitelgeometrvector operator *(Polozhitelgeometrvector obj1, Polozhitelgeometrvector obj2)
        {
            return new Polozhitelgeometrvector(obj1.X * obj2.X, obj1.Y * obj2.Y);
        }
       
        public override string ToString()
        {
            return $"X: = {X}, Y: = {Y}";
        } 
    }
}
