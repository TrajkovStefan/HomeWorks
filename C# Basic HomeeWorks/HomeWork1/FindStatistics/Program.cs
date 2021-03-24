using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string input1 = Console.ReadLine();
            int firstNumber;
            bool fNumber = int.TryParse(input1, out firstNumber);

            Console.WriteLine("Enter the second number");
            string input2 = Console.ReadLine();
            int secondNumber;
            bool secNumber = int.TryParse(input2, out secondNumber);
            int result;


            if (fNumber && secNumber && firstNumber >= 0 && secondNumber >= 0)
            {
                if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
                {
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Both numbers are even. The operation and result are {firstNumber} + {secondNumber} = {result}");
                }
                else if (firstNumber % 2 != 0 && secondNumber % 2 == 0)
                {
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"One of the numbers is odd. The operation and result are {firstNumber} - {secondNumber} = {result}");
                }
                else if (firstNumber % 2 == 0 && secondNumber % 2 != 0)
                {
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"One of the numbers is odd. The operation and result are {firstNumber} - {secondNumber} = {result}");
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Both numbers are odd. The operation and result are {firstNumber} / {secondNumber} = {result}");
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
