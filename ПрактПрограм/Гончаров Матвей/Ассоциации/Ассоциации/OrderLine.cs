using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ассоциации
{
    public class OrderLine
    {
        public int Quantity = 1;
        public double Cost = 14.5;
        public OrderLine(Item i)
        {
            Cost = i.UnitPrice * Quantity;
        }
        public OrderLine(int Quantity, Item i)
        {
            this.Quantity = Quantity;
            Cost = i.UnitPrice * Quantity;
        }


    }
}
