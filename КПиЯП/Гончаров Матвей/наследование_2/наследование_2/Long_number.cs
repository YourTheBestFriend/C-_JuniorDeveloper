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
