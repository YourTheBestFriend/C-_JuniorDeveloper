using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_2
{
    class PAIR
    {
        public int first { get; set; }
        public int second { get; set; }
        public PAIR() { }
        public PAIR(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        ////public virtual PAIR plus_(PAIR p2)
        ////{
        ////    return new PAIR(this.first + this.second, p2.first + p2.second);
        ////}
        public virtual object plus_(object p2)
        {
            return new PAIR(this.first + this.second, (p2 as PAIR).first + (p2 as PAIR).second);
        }
        //public virtual PAIR plus_(PAIR p2)
        //{
        //    return new Long_number(this.first + this.second, p2.first + p2.second);
        //}
        //        public virtual Long_number plus_(Long_number p2)
        //{
        //    return new Long_number(this.first + this.second, p2.first + p2.second);
        //}

        public static PAIR operator +(PAIR p1, PAIR p2)
        {
            return new PAIR(p1.first + p1.second, p2.first + p2.second);
        }

    }
}
