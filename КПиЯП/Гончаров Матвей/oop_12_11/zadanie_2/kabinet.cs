using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class kabinet
    {
        private List<workspace> listWorkSpaces;

        public List<workspace> ListWorkSpaces
        {
            set { ListWorkSpaces = value; }
        }
        public kabinet() {}
        public kabinet(params workspace[] x) 
        {
            for (int i = 0; i < x.Length; i++)
            {
                listWorkSpaces.Add(x[i]);
            }
        }
        public override string ToString() 
        {
            string s = "";
            for (int i = 0; i < listWorkSpaces.Count; i++)
            {
                s += $"Name_Workspace[{i}]: ";
                s += listWorkSpaces[i].ColvoPredmetov; 
            }
            return s; 
        }
    }
}
