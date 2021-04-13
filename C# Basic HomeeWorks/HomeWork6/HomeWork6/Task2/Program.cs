using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void SquaresNumbers(List<int> listOfNumbers)
        {
            List<int> squaresNumber = listOfNumbers.Select(x => x * x).ToList();
            foreach (int nums in squaresNumber)
            {
                Console.WriteLine(nums);
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                {2 },
                {5 },
                {3 },
                {8 },
                {12 },
                {4 },
                {7 },
                {5 },
                {6 },
                {9 },
            };

            SquaresNumbers(numbers);

            Console.ReadLine();
        }
    }
}
