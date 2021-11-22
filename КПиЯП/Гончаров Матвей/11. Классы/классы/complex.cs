using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    // internal: класс и члены класса с подобным модификатором доступны из любого места кода
    // в той же сборке, однако он недоступен для других программ и сборок
    // (как в случае с модификатором public).
    internal class complex
    {
        int x;
        int y;
        public complex() { }
        public complex(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public complex Plus(complex a)
        {
            return new complex(this.x + a.x, this.y + a.y);
        }
        public complex Minus(complex a)
        {
            return new complex(this.x - a.x, this.y - a.y);
        }
        public static complex Add(complex a, complex b)
        {
            return new complex(a.x + b.x, a.y + b.y);
        }
        public complex multiplication(complex a)
        {
            // (this.x * a.x + this.x * a.y + this.y * a.x + this.y * a.y
            // (2 + 3i) · (4 + 5i) = 2·4 + 2·5i + 3·4i + 3·5i2 = 8 + 10i + 12i - 15 = -7 + 22i
            return new complex(this.x * a.x + (-(this.y * a.y)), this.x * a.y + this.y * a.x);
        }
        public complex division(complex a)
        {
            // good luck
            return new complex((this.x * a.x + this.y * a.x) / (int)(Pow(a.x, 2) + Pow(a.y, 2)), (this.x * a.y + (-(this.y * a.x))) / (int)(Pow(a.x, 2) + Pow(a.y, 2)));
        }
        public bool equel(complex a, complex b)
        {
            if (a.x == b.x && a.y == b.y)
            {
                return true;
            }
            return false;
        }

        public complex pow2(int p)
        {
            return new complex(this.x * p, this.y * p);   
        }
        public void print_complex()
        {
            Console.WriteLine($"z = {this.x} + {this.y}i");
        }
    }
}
