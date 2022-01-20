using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    public class Personn
    {
        string name, surname;
        DateTime bornDate;
        
        public Personn()
        {
            name = "none";
            surname = "none";
            bornDate = DateTime.MinValue;
        }
        public Personn(string name, string surname, DateTime bornDate)
        {
            this.name = name;
            this.surname = surname;
            this.bornDate = bornDate;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public DateTime BornDate
        {
            get { return bornDate; }
            set { bornDate = value; }
        }
        public int Year
        {
            get { return bornDate.Year; }
            set {
                int month = bornDate.Month;
                int day = bornDate.Day;
                bornDate=new DateTime(value,month,day);
            }
        }

        public static bool operator ==(Personn a, Personn b)
        {
            return ((a.bornDate == b.bornDate) && (string.Compare(a.name, b.name) == 0) && (string.Compare(a.surname, b.surname) == 0));
        }
        public static bool operator !=(Personn a, Personn b)
        {
            return ((a.bornDate != b.bornDate) && (string.Compare(a.name, b.name) != 0) && (string.Compare(a.surname, b.surname) != 0)); 
        }
        public override int GetHashCode()
        {
            int hashCode = 0;
            foreach (var item in name)
            {
                hashCode += Convert.ToInt32(item);
            }
            foreach (var item in surname)
            {
                hashCode += Convert.ToInt32(item);
            }
            return hashCode;
        }
        public override bool Equals(object obj)
        {
            return (((bornDate.Equals((obj as Personn).bornDate))) && (name.Equals((obj as Personn).name)) && (surname.Equals((obj as Personn).surname)));
        }

        public virtual object DeepCopy()
        {
            return "DeepCopy";
        }
        public override string ToString() => $"Имя: {name}, Фамилия: {surname}, Дата рождения: {bornDate.ToShortDateString()}.";
        public virtual string ToShortstring() => $"Имя: {name}, Фамилия: {surname}.";

    }
}
