using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void PrintElements(IEnumerable collection)
        {
            foreach(int item in collection)
            {
                Console.WriteLine("========");
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items in the queue");
            bool success = int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine($"The numbers of items is {n}");
            Queue<int> intQueue = new Queue<int>();
            if (success)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter the {0} element", i);
                    bool success2 = int.TryParse(Console.ReadLine(), out int input);
                    intQueue.Enqueue(input);
                }
            }
            else
            {
                Console.WriteLine("The input cant be parsed!");
            }

            PrintElements(intQueue);

            Console.ReadLine();
        }
    }
}
