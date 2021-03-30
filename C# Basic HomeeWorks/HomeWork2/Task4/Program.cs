using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements of array");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[numberOfElements];
            Console.WriteLine($"Your array have {arrayOfIntegers.Length} length. Enter the {arrayOfIntegers.Length} numbers");
            int counter = 0;
            int i, j;

            for (i = 0; i < numberOfElements; i++) //add elements from input to array
            {
                Console.WriteLine("Enter the element with index {0}", i);
                arrayOfIntegers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = 0; j < arrayOfIntegers.Length - 1; j++) //read elements from array
            {
                if (arrayOfIntegers[j] == 3 && arrayOfIntegers[j + 1] == 3)
                {
                    counter++;
                }
            }

            Console.WriteLine($"{counter} times there are threes next to each other");

            Console.ReadLine();
        }
    }
}
