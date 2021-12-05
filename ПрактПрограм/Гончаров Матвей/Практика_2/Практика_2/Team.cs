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

        string getName()
        {
            return Name;
        }
        int getRegNumber()
        {
            return regNumber;
        }
        void setRegNumber(int regNumber)
        {
            try
            {
                if (regNumber <= 0)
                {
                    this.regNumber = regNumber;
                }
            }
            catch
            {
                Console.WriteLine("Error regNumber <= 0");
            }
        }
        public virtual object DeepCopy()
        {
            Team obj1 = new Team(this.Name, this.regNumber);
            return obj1;
        }
        //override virtual bool Equals(object obj) 
        //{
        //    if (obj == null) 
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
