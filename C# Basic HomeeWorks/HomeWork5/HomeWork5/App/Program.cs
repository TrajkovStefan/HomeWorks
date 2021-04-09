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
            SalesPerson[] salesPerson = new SalesPerson[]
            {
                new SalesPerson("Stefan", "Stefanovski")
            };

            Managers[] managers = new Managers[]
            {
                new Managers("Marko", "Markovski", 4000),
                new Managers("Petar", "Petrovski", 4500)
            };

            Contractor[] contractors = new Contractor[]
            {
                new Contractor("Petko", "Petkovski",8, 20, managers[0]),
                new Contractor("Robi", "Spasevski", 10, 18, managers[1])
            };

            Employee[] company = new Employee[]
            {
                managers[0],
                managers[1],
                salesPerson[0],
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
