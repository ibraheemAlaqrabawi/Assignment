using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Assignment
{
    public abstract class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        private double _Salary;
        public double salary
        { 
            set
            {
                if (value >= 0)
                {
                    _Salary = value;

                }
                else
                {
                    Console.WriteLine("negative number");
                }
            }
            get { return _Salary; } }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract double calSalary();
        public abstract void Displayinfo();

    }
}
