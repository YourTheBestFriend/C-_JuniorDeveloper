using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class MineralWater : Drinks
    {
        private string TypeWater { get; set; }
        public MineralWater(string typeWater, string name, double volume) : base(name, volume)
        {
            this.TypeWater = typeWater;
        }
        public override void TypeDrink() => Console.WriteLine("Это миниралка " + TypeWater);
    }
}
