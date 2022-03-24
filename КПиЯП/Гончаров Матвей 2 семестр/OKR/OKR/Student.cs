using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKR
{
    internal class Student
    {
        private string FIO;
        private string Fakultet;
        private int kurs;
        private int minmark;
        public string _FIO
        {
            get { return FIO; }
            set { FIO = value; }
        }
        public string _Fakultet
        {
            get { return Fakultet; }
            set { Fakultet = value; }
        }
        public int Kurs    
        {
            get { return kurs; }
            set 
            {
                if (value > 5 || value < 1)
                {
                    throw new Exception("error");
                }
                else 
                {
                    kurs = value;
                }
            }
        }
        public int Minmark
        {
            get { return minmark; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("error");
                }
                else
                {
                    minmark = value;
                }
            }
        }
        public Student() { }
        public Student(string FIO, string Fakultet, int kurs, int minmark)
        {
            _FIO = FIO;
            _Fakultet = Fakultet;
            Kurs = kurs;
            Minmark = minmark;
        }
        virtual public void PerevestiOnNextKurs()
        {
            if (Minmark > 3)
            {
                Kurs += 1;
            }
            else
            {
                Console.WriteLine("minmark < 3");
            }
        }
        virtual public double Stependia()
        {
            if (Minmark > 3)
            {
                if (Minmark == 4)
                {
                    if (Minmark == 5) // Minmark => 5
                    {
                        return 300;
                    }
                }
                return 200;
            }
            return 0;
        }
        public override string ToString()
        {
            return $"FIO: {_FIO}, Fakultet: {_Fakultet}, Kurs: {Kurs}, Minmark: {Minmark} Stependia: {this.Stependia()}";
        }
    }
}
