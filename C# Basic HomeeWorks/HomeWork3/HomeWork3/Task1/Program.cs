using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, reverse = "";
            int counter = 0;
            Console.WriteLine("Enter a word");
            input = Console.ReadLine(); 
            counter = input.Length - 1;
            while (counter >= 0)
            {
                reverse = reverse + input[counter];
                counter--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
    }
}

