using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some sentence");
            string sentence = Console.ReadLine();
            string[] splittedStrings = sentence.Split(" ");
            Console.WriteLine("The words are:");
            foreach (string str in splittedStrings)
            {

                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
