using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Petko", "Ana", "Tamara", "Jovan", "Kiko" };
            string[] studentsG2 = { "Stefan", "Filip", "Jovana", "Stasha", "Aleksandar" };
            Console.WriteLine("Enter student group: (there are 1 and 2)");
            int number = int.Parse(Console.ReadLine());
            
            if(number == 1)
            {
                Console.WriteLine("The students in G1 are: ");
                foreach(string students in studentsG1)
                {
                    Console.WriteLine(students);
                }
            }
            else if(number == 2)
            {
                Console.WriteLine("The students in G2 are: ");
                foreach (string students in studentsG2)
                {
                    Console.WriteLine(students);
                }
            }
            else
            {
                Console.WriteLine("We do not have a group with that number");
            }

            Console.ReadLine();
        }
    }
}
