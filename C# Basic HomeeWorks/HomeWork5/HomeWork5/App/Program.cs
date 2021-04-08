using System;
using Domain.Classes;
using Domain.Enums;

namespace App
{
    class Program
    {
        public bool IsManager(Employee employee)
        {
            return employee.Role == RoleEnum.Manager;
        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee("Marko", "Markovski", RoleEnum.Manager),
                new Employee("Stefan", "Stefanovski", RoleEnum.Sales),
                new Employee("Petar", "Petrovski", RoleEnum.Manager)
            };

            Contractor[] contractors = new Contractor[]
            {
                new Contractor("Petko", "Petkovski",8, 20),
                new Contractor("Robi", "Spasevski", 10, 18)
            };

            Employee[] company = new Employee[]
            {
                employees[0],
                employees[1],
                employees[2],
                contractors[0],
                contractors[1]
            };

            CEO[] ceoName = new CEO[]
            {
                new CEO(company, 15)
            };

            
            
            foreach(CEO details in ceoName)
            {
                Console.WriteLine("CEO:");
                Console.WriteLine(details.GetInfo());
                Console.WriteLine($"Salary of CEO is: {details.GetSalary()}$");
                Console.WriteLine("Employees:");
                details.PrintEmployees(company);
            }

            Console.ReadLine();
        }
    }
}
