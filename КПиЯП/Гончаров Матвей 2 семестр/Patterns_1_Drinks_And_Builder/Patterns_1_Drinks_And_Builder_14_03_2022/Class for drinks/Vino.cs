using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class Vino : AlcoholicDrinks
    {
        private string TypeVino { get; set; }
        public Vino(string name, double volume, double degreeAlcohol, string typeVino) : base(name, volume, degreeAlcohol)
        {
            this.TypeVino = typeVino;
        }

        public override void TypeAlcoholicDrink() => Console.WriteLine($"Это {TypeVino} вино.");
    }
}
