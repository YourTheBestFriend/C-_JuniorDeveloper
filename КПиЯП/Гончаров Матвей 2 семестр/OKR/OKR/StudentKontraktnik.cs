using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKR
{
    internal class StudentKontraktnik : Student
    {
        private bool isKontraktnik;
        public bool IsKontraktnik
        {
            get { return isKontraktnik; }
            set { isKontraktnik = value; }
        }
        public StudentKontraktnik() { }
        public StudentKontraktnik(string FIO, string Fakultet, int kurs, int minmark, bool isKontraktnik) : base(FIO, Fakultet, kurs, minmark)
        {
            IsKontraktnik = isKontraktnik;
        }
        public override void PerevestiOnNextKurs()
        {
            if (Minmark > 3)
            {
                if (IsKontraktnik == true)
                {
                    Kurs += 1;
                }
            }
            else
            {
                Console.WriteLine("minmark < 3");
            }
        }
        public override double Stependia()
        {
            return base.Stependia() / 0.22; // 1 р = 0.22 грн
        }
        public override string ToString()
        {
            return $"FIO: {_FIO}, Fakultet: {_Fakultet}, Kurs: {Kurs}, Minmark: {Minmark} Stependia: {this.Stependia()} IsKontraktnik: {IsKontraktnik}";
        }
    }
}
