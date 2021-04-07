using System;

namespace Exercise2
{
    class Program
    {
        static void NumberStats(double number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The {number} is positive ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The {number} is negative");
            }
            else
            {
                Console.WriteLine($"The {number} is = 0");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"The {number} is even");
            }
            else
            {
                Console.WriteLine($"The {number} is odd");
            }

            if (number % 1 == 0)
            {
                Console.WriteLine($"The {number} is integer");
            }
            else if (number % 1 != 0)
            {
                Console.WriteLine($"The {number} is decimal");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number");
                bool success = double.TryParse(Console.ReadLine(), out double input);

                if (success)
                {
                    NumberStats(input);
                }
                else
                {
                    Console.WriteLine("Input cant be parsed");
                }
                Console.WriteLine("Enter x or y");
                string exit = Console.ReadLine();
                if (exit == "x")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                }

            }
       
            Console.ReadLine();
        }
    }
}
