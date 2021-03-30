using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfEvenNumbers = new int[6];
            Console.WriteLine("Enter the first number");
            arrayOfEvenNumbers[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            arrayOfEvenNumbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            arrayOfEvenNumbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number");
            arrayOfEvenNumbers[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth number");
            arrayOfEvenNumbers[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sixth number");
            arrayOfEvenNumbers[5] = int.Parse(Console.ReadLine());
            int evenNumbers = 0;

            for (int i = 0; i < arrayOfEvenNumbers.Length; i++)
            {
                if (arrayOfEvenNumbers[i] % 2 == 0)
                {
                    evenNumbers += arrayOfEvenNumbers[i];
                }
            }

            Console.WriteLine("The sum of even numbers is " + evenNumbers);
            Console.ReadLine();
        }
    }
}
