using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_2
{
    class Long_number : PAIR
    {
        public int oldPartNumber;
        public int youngPartNumber;

        public Long_number() { }
        public Long_number(int oldPartNumber, int youngPartNumber)
        {
            this.oldPartNumber = oldPartNumber;
            this.youngPartNumber = youngPartNumber;
        }

        public override PAIR plus_(PAIR p2)
        {
            return new PAIR(this.first + this.second, p2.first + p2.second);
        }
        public override Long_number plus_(Long_number p2)
        {
            return new Long_number(this.oldPartNumber + this.youngPartNumber, p2.oldPartNumber + p2.youngPartNumber);
        }
        public Long_number minus_(Long_number lg2)
        {
            return new Long_number(this.oldPartNumber - this.youngPartNumber, lg2.oldPartNumber - lg2.youngPartNumber);
        }

        public Long_number nultiplexing_(Long_number lg2)
        {
            return new Long_number(this.oldPartNumber * this.youngPartNumber, lg2.oldPartNumber * lg2.youngPartNumber);
        }
    }
}
