using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //firstNumber
            Console.WriteLine("Enter the first number");
            string firstNumber = Console.ReadLine();
            int parsingFirstNumber;
            bool fNumber = int.TryParse(firstNumber, out parsingFirstNumber);

            //secondNumber
            Console.WriteLine("Enter the second number");
            string secondNumber = Console.ReadLine();
            int parsingSecondNumber;
            bool secNumber = int.TryParse(secondNumber, out parsingSecondNumber);

            //thirdNumber
            Console.WriteLine("Enter the third number");
            string thirdNumber = Console.ReadLine();
            int parsingThirdNumber;
            bool thrNumber = int.TryParse(thirdNumber, out parsingThirdNumber);

            //fourthNumber
            Console.WriteLine("Enter the foruth number");
            string fourthNumber = Console.ReadLine();
            int parsingFourthNumber;
            bool quarterNumber = int.TryParse(fourthNumber, out parsingFourthNumber);
            int sum;
            int resultOfAverage;

            if (fNumber && secNumber && thrNumber && quarterNumber)
            {
                sum = parsingFirstNumber + parsingSecondNumber + parsingThirdNumber + parsingFourthNumber;
                resultOfAverage = sum / 4;
                Console.WriteLine($"The average of {parsingFirstNumber}, {parsingSecondNumber}, {parsingThirdNumber}, {parsingFourthNumber} is: {resultOfAverage}");
            }
            else
            {
                Console.WriteLine("You must enter numbers");
            }

            Console.ReadLine();
        }
    }
}
