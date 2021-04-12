using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Managers : Employee
    {
        private double _bonus { get; set; }

        public Managers(string firstName, string lastName) :base(firstName, lastName)
        {
            Role = RoleEnum.Manager;
        }

        public double AddBonus(double amountBonus)
        {
            return _bonus += amountBonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
