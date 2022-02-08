using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_zarplata
{
    internal class WorkerFixSalary : Worker
    {
        double FixSalary = 800;
        public WorkerFixSalary(string name, int id, double FixSalary) : base(name, id)
        {
            this.FixSalary = FixSalary;
        }

        public override double returnSalary()
        {
            return FixSalary;
        }
        public override string ToString() => $"Id = {this.Id}, Name = {this.Name}, Salary = {returnSalary()}";
    }
}
