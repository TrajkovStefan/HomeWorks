using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string someText = "The whole group of G2 loves C#. They find learning this language fund and easy!";
            int index = someText.IndexOf(".");
            Console.WriteLine(index);

            string subText = someText.Substring(index+1);
            Console.WriteLine(subText);

            Console.ReadLine();
        }
    }
}
