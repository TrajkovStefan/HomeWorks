using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public CEO(Employee[] arrayOfEmployees, int shares)
        {
            FirstName = "Mark";
            LastName = "Anderson";
            Salary = 1500;
            Employees = arrayOfEmployees;
            Shares = shares;
        }

        public double AddSharesPrice(double number)
        {
            return _sharesPrice = number;
        }

        public void PrintEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            double sharesPrice = AddSharesPrice(100);
            return Salary + Shares * sharesPrice;   
        }
    }
}
