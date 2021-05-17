using System;

namespace SEDC.HomeWork.TimeTracking.Services.Helpers
{
    public class MessageHelper
    {
        public static void PrintMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
