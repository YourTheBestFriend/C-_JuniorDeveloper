using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfece_2711
{
    interface Ibankomat
    {
        public static string adress { get; set; }
        void snatDengi(double money);
    }
}
