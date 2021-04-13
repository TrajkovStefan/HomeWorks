using Domain_Bonus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){FirstName = "Stefan", LastName = "Stefanovski", Age = 23},
                new Employee(){FirstName = "Petar", LastName = "Petrovski", Age = 20},
                new Employee(){FirstName = "Petko", LastName = "Petkovski", Age = 24},
                new Employee(){FirstName = "Sara", LastName = "Stefanovska", Age = 20},
                new Employee(){FirstName = "Bojan", LastName = "Damchevski", Age = 20},
                new Employee(){FirstName = "Stefan", LastName = "Trajkov", Age = 36},
                new Employee(){FirstName = "Aleksandar", LastName = "Manasiev", Age = 36},
                new Employee(){FirstName = "Igor", LastName = "Angelovski", Age = 29},
                new Employee(){FirstName = "Robert", LastName = "Spasovski", Age = 21},
                new Employee(){FirstName = "Ana", LastName = "Stojanovska", Age = 26},
            };

            Dictionary<int, List<string>> myDictionary = new Dictionary<int, List<string>>();
            foreach (var employee in employees)
            {
                if (myDictionary.ContainsKey(employee.Age))
                {
                    List<string> newList = myDictionary[employee.Age];
                    newList.Add($"{employee.FirstName} {employee.LastName}");
                    myDictionary[employee.Age] = newList;
                }
                else
                {
                    myDictionary.Add(employee.Age, new List<string> { $"{ employee.FirstName} {employee.LastName}" });
                }
            };

            foreach (var item in myDictionary)
            {
                Console.WriteLine($"{item.Key} -");
                foreach (var name in item.Value)
                {
                    Console.WriteLine(name);
                }
            }

            Console.ReadLine();
        }
    }
}
