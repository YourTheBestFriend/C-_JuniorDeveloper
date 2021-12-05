using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ассоциации
{
    public class Order
    {
        public int Number;
        public DateTime CreationDate;
        public string Address;
        public bool ExpressDelivery;

        public double TotalCost;

        public Order(){ }
        public Order(int Number, DateTime CreationDate, string Address, bool ExpressDelivery) 
        {
            // 
        }
        double GetTotalCost()
        {

            return TotalCost;
        }
    }
}
