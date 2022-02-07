using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Наследование_07_02_2022
{
    abstract internal class Gosudarstvo
    {
        int kredit = 0;
        string name;
        string denezhnayaEden;
        string simvolika;
        public int Kredit
        {
            get { return kredit; }
            set { kredit = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string DenezhnayaEden
        {
            get { return denezhnayaEden; }
            set { denezhnayaEden = value; }
        }
        public string Simvolika
        {
            get { return simvolika; }
            set { simvolika = value; }
        }

        static Gosudarstvo() { }
        // С параметрами
        public Gosudarstvo(string name, string denezhnayaEden, string simvolika) 
        {
            Name = name;
            DenezhnayaEden = denezhnayaEden;
            Simvolika = simvolika;
        }
        
        // Методы работы с кредитом для переопределеия их в производных классах
        public abstract void UvelichKred_10(ref int x);

        // public abstract void UmenshKred_10(out int x);
       
    }
}
