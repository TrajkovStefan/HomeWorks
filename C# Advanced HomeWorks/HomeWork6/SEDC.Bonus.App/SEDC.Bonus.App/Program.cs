using SEDC.Bonus.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SEDC.Bonus.App
{
    class Program
    {
        public static void WriteAndReadPeople(string filePath)
        {
            List<Person> allPeople = new List<Person>();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Stefan Trajkov 23");
                sw.WriteLine("Bojan Damchevski 20");
                sw.WriteLine("Aleksandar Manasijevikj 28");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("People saved in peopleList.txt\n");
                Console.ResetColor();
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                for (int i = 0; i < 3; i++)
                {
                    string person = sr.ReadLine();
                    string[] personSplited = person.Split(" ");
                    Person newPerson = new Person(personSplited[0], personSplited[1], Convert.ToInt32(personSplited[2]));
                    allPeople.Add(newPerson);
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("All added people with stream reading");
            Console.ResetColor();
            foreach (Person person in allPeople)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
            }
        }

        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + "People";
            string filePath = folderPath + @"\peopleList.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder People created!");
            }

            WriteAndReadPeople(filePath);

            Console.ReadLine();
        }
    }
}
