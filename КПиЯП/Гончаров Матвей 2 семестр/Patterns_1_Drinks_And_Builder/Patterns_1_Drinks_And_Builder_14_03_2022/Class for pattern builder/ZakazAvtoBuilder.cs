using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class ZakazAvtoBuilder : AvtoBuilder
    {
        public override void SetDvigatel() => this.Avto.Dvigatel = new Dvigatel { Sort = "ZakazAvto Dvigatel 1000L" };
        public override void SetAudioSystem() => this.Avto.AudioSystem = new AudioSystem { Name = "Audio System 12H" };
    }
}
