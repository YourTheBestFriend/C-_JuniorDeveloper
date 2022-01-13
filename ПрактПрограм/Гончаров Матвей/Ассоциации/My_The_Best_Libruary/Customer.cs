using System;

namespace My_The_Best_Libruary
{
    [Serializable]
    public class Customer
    {
        public int Code = 0;
        public int ContactPhone = 0;
        public string FullName = "none";
        public bool Privileged = false;

        public Customer() {}
        public Customer(int Code, int ContactPhone, string FullName, bool Privileged)
        {
            this.Code = Code;
            this.ContactPhone = ContactPhone;
            this.FullName = FullName;
            this.Privileged = Privileged;
        }
    }
}
