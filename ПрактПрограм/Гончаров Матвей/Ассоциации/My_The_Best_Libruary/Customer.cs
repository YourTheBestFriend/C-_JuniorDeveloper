using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_The_Best_Libruary
{
    public class Customer
    {
        public int Code = 0;
        public int ContactPhone = 0;
        public string FullName = "none";
        public bool Privileged = false;

        // Типо у клиента заказ
        //public Order ord = new Order();

        public Customer() {}
        public Customer(int Code, int ContactPhone, string FullName, bool Privileged) // Order ord
        {
            this.Code = Code;
            this.ContactPhone = ContactPhone;
            this.FullName = FullName;
            this.Privileged = Privileged;
            //this.ord = ord;
        }
    }
}
