using System;

namespace WorkingDays
{
    class Program
    {
        static void GetDate(int year, int month, int day)
        {
            DateTime customDate = new DateTime(1999, 1, 1);
            DateTime currentDate = DateTime.Today;

            if (day > 0 || day < 31)
            {
                if (month > 1 || month < 12)
                {
                    DateTime date = new DateTime(year, month, day);
                    if (date <= currentDate && date >= customDate)
                    {
                        if (day == 1 && month == 7 || day == 7 && month == 1 || day == 20 && month == 4 || day == 1 && month == 5 || day == 25 && month == 5 || day == 3 && month == 8 || day == 12 && month == 10 || day == 23 && month == 10 || day == 8 && month == 12)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("No working day");
                        }
                        else if (date.DayOfWeek.ToString() == "Saturday" || date.DayOfWeek.ToString() == "Sunday")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("It's a WEEKEND");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Working day");
                        }
                    }
                    else
                    {
                        throw new Exception("You must enter a year between 1999 and 2021");
                    }
                }
                else
                {
                    throw new Exception("Invalid month");
                }
            }
            else
            {
                throw new Exception("Invalid day");
            }
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    int year, month, day;
                    Console.WriteLine("Enter day as number(1 - 31)");
                    bool success = int.TryParse(Console.ReadLine(), out day);
                    Console.WriteLine("Enter month as number(1-12)");
                    bool success1 = int.TryParse(Console.ReadLine(), out month);
                    Console.WriteLine("Enter year (1991-2021)");
                    bool success2 = int.TryParse(Console.ReadLine(), out year);
                    if (success && success1 && success2)
                    {
                        GetDate(year, month, day);
                    }
                    else
                    {
                        throw new Exception("Cant parsed input");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Do you want to check other date? yes/no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Goodbye");
                }
            }
            Console.ReadLine();
        }
    }
}
