using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_08_02_2022
{
    /// <summary>
    /// Каталог телефонных номеров.
    /// </summary>
    public class Catalog
    {
        /// <summary>
        /// Список телефонных номеров.
        /// </summary>
        public List<Phone> Phones { get; set; } = new List<Phone>();
    }
}
