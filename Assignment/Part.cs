using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Part : Employee, IWorkable
    {
        public int Houer { get; set; }
        public double Rate {  get; set; }
        public Part(int id, string name, int houer,double rate ) : base(id, name)
        {
            Houer = houer;
            Rate = rate;
        }

        public override double calSalary()
        {
            salary = Houer * Rate;
            return salary;      
        }

        public override void Displayinfo()
        {
            Console.WriteLine($"id={Id} name={Name} salary={calSalary()} type:{Work()}");
        }
        public string Work()
        {
            return"part timer";
        }
    }
}
