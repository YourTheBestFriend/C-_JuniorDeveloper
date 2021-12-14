using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения_2_class
{
    class Reis
    {
        private int numberReisa; // Номер рейса
        private string typeBus; // Тип автобуса
        private string placeNaznach; // Место назначания

        private string otbitia; // Время отбытия
        private string pribitia; // Время прибытия

        // Свойства
        public int NumberReisa
        {
            get => numberReisa;
            set { numberReisa = value; }
        }

        public string TypeBus
        {
            get => typeBus;
            set { typeBus = value; }
        }
        public string PlaceNaznach
        {
            get => placeNaznach;
            set { placeNaznach = value; }
        }
        public string Otbitia
        {
            get => otbitia;
            set { otbitia = value; }
        }
        public string Pribitia
        {
            get => pribitia;
            set { pribitia = value; }
        }

        // Constructor
        public Reis(int numberReisa, string typeBus, string placeNaznach, string otbitia, string pribitia)
        {
            this.numberReisa = numberReisa;
            this.typeBus = typeBus;
            this.placeNaznach = placeNaznach;
            this.otbitia = otbitia;
            this.pribitia = pribitia;
        }

        public override string ToString() => $"numberReisa: {numberReisa}, Время отбытия: {otbitia}, Точка назначения {placeNaznach}";
    }
}
