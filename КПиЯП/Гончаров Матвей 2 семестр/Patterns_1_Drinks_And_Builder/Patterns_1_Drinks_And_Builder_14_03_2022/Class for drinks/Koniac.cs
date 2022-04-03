using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{

    class Koniac : AlcoholicDrinks
    {
        private string TypeKoniac { get; set; }

        public Koniac() { }

        public Koniac(string name, double volume, double degreeAlcohol, string typeCognac) : base(name, volume, degreeAlcohol)
        {
            this.TypeKoniac = typeCognac;
        }

        public override void TypeAlcoholicDrink() => Console.WriteLine($"Коньяк: {Name}, тип: {TypeKoniac}, градус: {DegreeAlcohol}, обьём: {Volume} ");
    }
}
