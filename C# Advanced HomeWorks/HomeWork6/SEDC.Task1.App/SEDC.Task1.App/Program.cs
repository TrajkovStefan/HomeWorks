using System;
using System.IO;

namespace SEDC.Task1.App
{
    class Program
    {
        public static string Calculate(int num1, int num2)
        {
            int sum = num1 + num2;
            string result = $"{num1} + {num2} = {sum}\n";
            return result;
        }
        
        public static string UserInputs()
        {
            string results = "";
            int counter = 3;
            while (counter > 0)
            {
                Console.WriteLine("Enter first number");
                bool successFirstNumber = int.TryParse(Console.ReadLine(), out int firstNumber);
                if (successFirstNumber)
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Enter second number");
                        bool successSecondNumber = int.TryParse(Console.ReadLine(), out int secondNumber);
                        if (successSecondNumber)
                        {
                            results += Calculate(firstNumber, secondNumber);
                            Console.WriteLine(Calculate(firstNumber, secondNumber));
                            counter--;
                            flag = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You must enter number");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter number");
                    Console.ResetColor();
                }
            }
            return results;
        }

        public static void WriteAndReadTextFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(UserInputs());
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string result = sr.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ResetColor();
                Console.WriteLine(result);
            }
        }

        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string exerciseFolder = appPath + "Exercise";
            string calculationsFile = exerciseFolder + @"\calculations.txt";

            if (!Directory.Exists(exerciseFolder))
            {
                Directory.CreateDirectory(exerciseFolder);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Exercise folder created!");
                Console.ResetColor();
            }

            WriteAndReadTextFile(calculationsFile);

            Console.ReadLine();
        }
    }
}
