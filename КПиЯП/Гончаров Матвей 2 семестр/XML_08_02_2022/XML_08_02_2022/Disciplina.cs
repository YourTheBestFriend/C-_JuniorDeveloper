using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_08_02_2022
{
    /// <summary>
    /// Дисциплина
    /// </summary>
    public class Disciplina
    {
       
        public string Name { get; set; }

       
        public int Number { get; set; }

        
        public string Remark { get; set; }

        
        public bool Important { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
