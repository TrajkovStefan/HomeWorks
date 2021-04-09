using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) :base(firstName, lastName)
        {
            Salary = 500;
            Role = RoleEnum.Sales;
        }

        public double AddSuccessRevenue(double number)
        {
          return _successSaleRevenue = number;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                Salary += 500;
            }
            else if (_successSaleRevenue > 2000 && _successSaleRevenue < 5000)
            {
                Salary += 1000;
            }
            else
            {
                Salary += 1500;
            }
            return Salary;
        }   
    }
}
