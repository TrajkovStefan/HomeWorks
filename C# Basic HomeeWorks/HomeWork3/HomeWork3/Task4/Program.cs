using System;

namespace Task4
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Multi(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Divi(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Calculator(string operation, int num1, int num2)
        {
            if (operation == "+")
            {
                Console.WriteLine("The sum is: " + Sum(num1, num2));
            }
            else if (operation == "-")
            {
                Console.WriteLine("The difference is: " + Substract(num1, num2));
            }
            else if (operation == "*")
            {
                Console.WriteLine("The product is: " + Multi(num1, num2));
            }
            else if (operation == "/")
            {
                Console.WriteLine("The quotient is: " + Divi(num1, num2));
            }
            else
            {
                Console.WriteLine("Wrong operator");
            }
        }
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Enter the first number");
            bool success = int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter the second number");
            bool success2 = int.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Enter the operation (+ , - , * , /)");
            string operation = Console.ReadLine();
            if (success && success2)
            {
                Calculator(operation, number1, number2);
            }
            else
            {
                Console.WriteLine("Numbers cant be parsed");
            }


            Console.ReadLine();
        }
    }
}
