using System;

namespace Task5
{
    class Program
    {
        static void AgeCalculator(DateTime myBirthday)
        {
            DateTime currentDate = DateTime.Today;
            int year = currentDate.Year - myBirthday.Year;
            int age = 0;
            if (myBirthday.Month > currentDate.Month)
            {
                age = year - 1;
                Console.WriteLine($"You have {age} years old");
            }
            else if (myBirthday.Month <= currentDate.Month)
            {
                if (myBirthday.Month == currentDate.Month && myBirthday.Day == currentDate.Day)
                {
                    age = year;
                    Console.WriteLine("Happy Birthday");
                }
                else if (myBirthday.Month == currentDate.Month && myBirthday.Day > currentDate.Day)
                {
                    age = year - 1;
                }
                else if (myBirthday.Month == currentDate.Month && myBirthday.Day < currentDate.Day)
                {
                    age = year;
                }
                else if (myBirthday.Month < currentDate.Month)
                {
                    age = year;
                }
                Console.WriteLine($"You have {age} years old");

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday year as (dd/mm/yyyy)");
            bool success = DateTime.TryParse(Console.ReadLine(), out DateTime dateBirday);
            if (success)
            {
                AgeCalculator(dateBirday);
            }
            else
            {
                Console.WriteLine("Invalid birth date");
            }

            Console.ReadLine();
        }
    }
}
