using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class Avto
    {
        public Dvigatel Dvigatel { get; set; }
        public AudioSystem AudioSystem { get; set; }
        public override string ToString() => $"Info: {Dvigatel.Sort }, Audio System: {AudioSystem.Name}\n";
    }
}
