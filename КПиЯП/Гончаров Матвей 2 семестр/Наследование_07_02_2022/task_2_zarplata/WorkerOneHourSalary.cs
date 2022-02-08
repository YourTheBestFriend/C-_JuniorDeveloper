using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_zarplata
{
    internal class WorkerOneHourSalary : Worker
    {
        double hourStavka = 50.0;

        public WorkerOneHourSalary(string name, int id, double hourStavka) : base(name, id)
        {
            this.hourStavka = hourStavka;
        }

        public override double returnSalary()
        {
            return 20.8 * 8 * hourStavka;
        }
        public override string ToString() => $"Id = {this.Id}, Name = {this.Name}, Salary = {returnSalary()}";
    }
}
