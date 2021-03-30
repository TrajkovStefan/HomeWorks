using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[] { 5, 2, 8, 4, 12, 25, 1, 9, 13, -1 };
            int min, max;
            min = arrayOfNumbers[0];
            max = arrayOfNumbers[0];

            for(int i =0; i<arrayOfNumbers.Length; i++)
            {
                if(arrayOfNumbers[i] > max)
                {
                    max = arrayOfNumbers[i];
                }
                if(arrayOfNumbers[i] < min)
                {
                    min = arrayOfNumbers[i];
                }
            }
            Console.WriteLine("Maximum number of array is: " + max);
            Console.WriteLine("Minimum number of array is: " + min);

            Console.ReadLine();
        }
    }
}
