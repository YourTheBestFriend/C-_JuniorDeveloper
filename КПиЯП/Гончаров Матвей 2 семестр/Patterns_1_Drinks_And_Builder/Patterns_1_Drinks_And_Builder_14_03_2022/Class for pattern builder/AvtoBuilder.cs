using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    abstract class AvtoBuilder
    {
        public Avto Avto { get; private set; }
        public void CreateAvto()
        {
            Avto = new Avto();
        }
        public abstract void SetDvigatel();
        public abstract void SetAudioSystem();
    }
}
