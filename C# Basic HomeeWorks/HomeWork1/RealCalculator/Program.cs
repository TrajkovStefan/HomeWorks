using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string firstInput = Console.ReadLine();
            int parsingFirstInput;
            bool success1 = int.TryParse(firstInput, out parsingFirstInput);
            Console.WriteLine("Enter the second number");
            string secondInput = Console.ReadLine();
            int parsingSecondInput;
            bool success2 = int.TryParse(secondInput, out parsingSecondInput);
            Console.WriteLine("Enter the operation");
            string operation = Console.ReadLine();
            int result;

            if (success1 && success2)
            {
                if (operation == "+")
                {
                    result = parsingFirstInput + parsingSecondInput;
                    Console.WriteLine("The result is " + result);
                }
                else if (operation == "-")
                {
                    result = parsingFirstInput - parsingSecondInput;
                    Console.WriteLine("The result is " + result);
                }
                else if (operation == "*")
                {
                    result = parsingFirstInput * parsingSecondInput;
                    Console.WriteLine("The result is " + result);
                }
                else if (operation == "/")
                {
                    result = parsingFirstInput / parsingSecondInput;
                    Console.WriteLine("The result is " + result);
                }
                else
                {
                    Console.WriteLine("You must enter an operation to add(+), subtract(-), multiply(*) or divide(/).");
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
