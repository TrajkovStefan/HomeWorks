using System;

namespace Task3
{
    class Program
    {
        static void SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("The sum of digits is: " + sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            bool success = int.TryParse(Console.ReadLine(), out int number);
            if (success)
            {
                SumOfDigits(number);
            }
            else
            {
                Console.WriteLine("The input cant be parsed!");
            }

            Console.ReadLine();
        }
    }
}
