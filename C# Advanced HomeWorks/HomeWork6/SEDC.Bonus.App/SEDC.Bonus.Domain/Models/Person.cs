using System;

namespace SEDC.Bonus.Domain.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age { get; set; }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Age must be greater than 0");
                }
                _age = value;
            }
        }
    }
}