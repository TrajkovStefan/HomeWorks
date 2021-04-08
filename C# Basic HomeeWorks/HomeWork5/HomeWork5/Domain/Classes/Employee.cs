using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public RoleEnum Role { get; set; }

        public Employee(string firstName, string lastName, RoleEnum role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
        public Employee()
        {
            Salary = 600;
        }

        public string GetInfo()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}$";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
