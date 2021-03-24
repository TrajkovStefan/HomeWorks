using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string firstInput = Console.ReadLine();
            int parsingFirstNumber;
            bool firstNumber = int.TryParse(firstInput, out parsingFirstNumber);

            Console.WriteLine("Enter the second number");
            string secondNumber = Console.ReadLine();
            int parsingSecondNumber;
            bool secNumber = int.TryParse(secondNumber, out parsingSecondNumber);
            Console.WriteLine("First number is: " +parsingFirstNumber);
            Console.WriteLine("Second number is: " +parsingSecondNumber);

            parsingFirstNumber = parsingFirstNumber * parsingSecondNumber;
            parsingSecondNumber = parsingFirstNumber / parsingSecondNumber;
            parsingFirstNumber = parsingFirstNumber / parsingSecondNumber;

            Console.WriteLine($"After swapping first number is {parsingFirstNumber}, second number is {parsingSecondNumber}");
            Console.ReadLine();
        }
    }
}
