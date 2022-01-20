using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Team : INameAndCopy
    {
        protected string compName;
        int registrNum;
        public string name { get; set; }

        public Team(string compName, int registrNum)
        {
            this.compName = compName;
            this.registrNum = registrNum;
        }
        public Team()
        {
            compName = "None";
            registrNum = 0;
        }

        public string CompName
        {
            get { return compName; }
            set { compName = value; }
        }
        public int RegistrNum
        {
            get { return registrNum; }
            set
            {
                Exception e = new Exception("Номер не подходит!");
                if (value <= 0)
                    Console.WriteLine(e);
                else
                    registrNum = value;
            }
        }

        public static bool operator ==(Team a, Team b)
        {
            return ((string.Compare(a.compName,b.compName)==0) && (a.registrNum == b.registrNum));
        }
        public static bool operator !=(Team a, Team b)
        {
            return ((string.Compare(a.compName, b.compName) != 0) || (a.registrNum != b.registrNum));
        }
        public override int GetHashCode()
        {
            int hashcod = 0;
            hashcod += registrNum;
            foreach (char item in compName)
            {
                hashcod += Convert.ToInt32(item);
            }
            hashcod += registrNum;            
            return hashcod;
        }
        public override bool Equals(object obj)
        {
            return (((compName.Equals((obj as Team).compName))) && (registrNum.Equals((obj as Team).registrNum)));
        }
        public object DeepCopy()
        {
            Team other = (Team)this.MemberwiseClone();
            return other;
        }

        public override string ToString() => $"Название компании: {compName}, Регистрационный номер: {registrNum}";
    }
}
