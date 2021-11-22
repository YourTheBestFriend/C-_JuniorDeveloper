using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseOOP
{
    class Massa
    {
        private readonly double massa;

        private Massa(double massa)
        {
            this.massa = massa;
        }
        // Превращаю все в граммы
        static public Massa SetGrammMass(double massa) => new Massa(massa);
        static public Massa SetFuntMass(double funtMassa) => new Massa(funtMassa * 453.59237);
        static public Massa SetUnicMass(double unicMassa) => new Massa(unicMassa * (453.59237 / 16));
        
        // Для различных единицах измерения
        public double Gramm { get => this.massa; }
        public double Funt { get => this.massa / 453.59237; }
        public double Unic { get => this.massa / (453.59237 / 16); }

        // Операции
        public Massa Add(Massa a) => new Massa(this.massa + a.massa);
        public Massa Sub(Massa a) => new Massa(this.massa - a.massa);

        // output
        public override string ToString() => $"В граммах {Gramm:f4}, в фунтах {Funt:f4}, в унциях {Unic:f4}";
    }
}
