using System;

namespace Task5
{
    class Program
    {
        static void AgeCalculator(string myBirthday)
        {
            DateTime convertedMyBirthday = new DateTime(int.Parse(myBirthday), 1, 1);
            DateTime currentDate = DateTime.Today;
            int myAge = currentDate.Year - convertedMyBirthday.Year;
            Console.WriteLine($"I have {myAge} old");



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday year");
            string myInput = Console.ReadLine();
            AgeCalculator(myInput);

            Console.ReadLine();
        }
    }
}
