using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Managers : Employee
    {
        private double _bonus { get; set; }

        public Managers(string firstName, string lastName, double bonus) :base(firstName, lastName)
        {
            _bonus = bonus;
            Role = RoleEnum.Manager;
        }

        public double AddBonus()
        {
            return _bonus;
        }

        public override double GetSalary()
        {
            return Salary += _bonus;
        }
    }
}
