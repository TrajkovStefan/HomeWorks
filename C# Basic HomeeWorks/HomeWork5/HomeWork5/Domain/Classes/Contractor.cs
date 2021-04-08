using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public RoleEnum Responsible{ get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour)
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
        }
        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public RoleEnum CurrentPosition()
        {
            return Role;
        }
    }
}
