using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Team : INameAndCopy
    {
        protected string Name;
        protected int regNumber;

        public Team()
        {
            Name = "None";
            regNumber = 1;
        }
        public Team(string nameOrganization, int regNumber)
        {
            this.Name = nameOrganization;
            this.regNumber = regNumber;
        }

        string GetName()
        {
            return Name;
        }
        int GetRegNumber()
        {
            return regNumber;
        }
        void SetRegNumber(int regNumber)
        {
            if (regNumber <= 0)
            {
                this.regNumber = regNumber;
            }
            else
            {
                throw new Exception("Error regNumber <= 0");
            }
        }
        public virtual object DeepCopy()
        {
            Team obj1 = new Team(this.Name, this.regNumber);
            return obj1;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator ==(Team t1, Team t2)
        {
            if (t1.Name == t2.Name && t1.regNumber == t2.regNumber)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Team t1, Team t2)
        {
            if (t1.Name != t2.Name || t1.regNumber != t2.regNumber)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString() => $"Name: = {GetName()}, regNum = {GetRegNumber()}";
    }
}
