using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class workspace
    {
        private string whereSituate;
        private int colvoPredmetov;
        private Student student;
        public Student Student
        {
            get =>student;
            set { student = value; }
        }
        public string ColvoPredmetov
        {
            set { whereSituate = value; }
            get { return whereSituate; }
        }
        public workspace()
        {
            whereSituate = "none";
            colvoPredmetov = 0;
        }
        public workspace(string whereSituate, int colvoPredmetov)
        {
            this.whereSituate = whereSituate;
            this.colvoPredmetov = colvoPredmetov;
        }
        // Типо чьё рабочее место
        public string returnName()
        {
            return student.Name;
        }
    }
}
