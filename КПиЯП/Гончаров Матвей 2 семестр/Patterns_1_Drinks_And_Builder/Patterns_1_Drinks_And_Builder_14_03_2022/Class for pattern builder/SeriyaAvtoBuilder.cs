using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class SeriyaAvtoBuilder : AvtoBuilder
    {
        public override void SetDvigatel() => this.Avto.Dvigatel = new Dvigatel { Sort = "SeriyaAvto Dvigatel 990L" };
        public override void SetAudioSystem() => this.Avto.AudioSystem = new AudioSystem { Name = "Without Audio System" };
    }
}
