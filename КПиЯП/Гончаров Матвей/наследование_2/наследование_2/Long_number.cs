using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_2
{
    class Long_number : PAIR
    {
        //public int oldPartNumber;
        public int youngPartNumber=9;

        public Long_number() { }
        public Long_number(int oldPartNumber, int youngPartNumber) : base(oldPartNumber, youngPartNumber)
        {
            //this.oldPartNumber = oldPartNumber;
            //this.youngPartNumber = youngPartNumber;
        }

        //public override PAIR plus_(PAIR p2)
        //{
        //    return new PAIR(this.first + this.second, p2.first + p2.second);
        //}

        public override object plus_(object p2)
        {
            return new Long_number(this.first + (p2 as Long_number).first,this.second  + (p2 as Long_number).second);
        }
        ////public override PAIR plus_(PAIR p2)
        ////{
        ////    return new PAIR(this.first + p2.first, second + p2.second);
        ////}
        //public Long_number plus_(Long_number p2)
        //{
        //    return new Long_number(this.first + p2.first, second + p2.second);
        //}
        public Long_number minus_(Long_number lg2)
        {
            return new Long_number(this.first - lg2.first, second - lg2.second);
        }

        public Long_number nultiplexing_(Long_number lg2)
        {
            return new Long_number(this.first * lg2.first, second * lg2.second);
        }
    }
}
