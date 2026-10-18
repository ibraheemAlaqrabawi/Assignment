using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    internal class Full : Employee, IWorkable
    {
        public double MonthlySalary {  get; set; }
        public Full(int id, string name, double monthlySalary) : base(id, name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double calSalary()
        {
            salary = MonthlySalary;
            return salary;
        }

        public override void Displayinfo()
        {
         Console.WriteLine($"id={Id} name={Name} salary={calSalary()} type:{Work()}");
        }

        public string Work()
        {
            return "full time";
        }
    }
}
