using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ассоциации
{
    public class Customer
    {
        public int Code;
        public int ContactPhone;
        public string FullName;
        public bool Privileged;

        public Customer(int Code, int ContactPhone, string FullName, bool Privileged)
        {
            this.Code = Code;
            this.ContactPhone = ContactPhone;
            this.FullName = FullName;
            this.Privileged = Privileged;
        }
    }
}
