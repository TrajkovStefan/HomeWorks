using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number from 1 to 3");
            string input = Console.ReadLine();
            int number;
            bool successNumber = int.TryParse(input, out number);

            if (successNumber)
            {
                if(number == 1)
                {
                    Console.WriteLine("You got a new car!");
                }
                else if(number == 2)
                {
                    Console.WriteLine("You got a new plane!");
                }
                else if(number == 3)
                {
                    Console.WriteLine("You got a new bike!");
                }
                else if(number > 3) 
                {
                    Console.WriteLine("You must enter a number less than 3");
                }
            }
            else
            {
                Console.WriteLine("An error occured! The input is not a whole number!");
            }

            Console.ReadLine();
        }
    }
}
