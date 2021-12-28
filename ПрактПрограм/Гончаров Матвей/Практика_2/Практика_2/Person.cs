using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// work with date
using static System.DateTime;

namespace Практика_2
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime dt;        
        public Person(string name, string surname, DateTime dt)
        {
            this.name = name;
            this.surname = surname;
            this.dt = dt;
        }
        public Person()
        {
            this.name = "noname";
            this.surname = "nosurname";
            this.dt = new DateTime();
        }
        // get
        public string getName()
        {
            return name;
        }
        public string getSurName()
        {
            return surname;
        }
        public DateTime getDateTime()
        {
            return dt;
        }
        // get year
        public int getYearDateTime()
        {
            return this.getDateTime().Year;
        }
        // set
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSurName(string surname)
        {
            this.surname = surname;
        }
        public void setDateTime(DateTime dt)
        {
            this.dt = dt;
        }
        // set year on datetime
        public void setYearDateTime(int dt_y)
        {
            this.dt = new DateTime(dt_y, getDateTime().Month, getDateTime().Day);
        }

        // metods
        public override string ToString()
        {
            return name + " " + surname + dt.ToString();        
        }
        public virtual string ToShortString()
        {
            return name + " " + surname;
        }
       
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator ==(Person p1, Person p2)
        {
            if (p1.getName() == p2.getName() && p1.getSurName() == p2.getSurName() && p1.getYearDateTime() == p2.getYearDateTime())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            if (p1.getName() != p2.getName() || p1.getSurName() != p2.getSurName() || p1.getYearDateTime() != p2.getYearDateTime())
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public virtual object DeepCopy()
        {
            Person obj1 = new Person(this.name, this.surname, this.dt);
            return obj1;
        }
    }
}
