using System;

namespace WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime customDate = new DateTime(1999, 1, 1);
            DateTime currentDate = DateTime.Today;
            bool flag = true;
            while (flag)
            {
                try
                {
                    int year, month, day;

                    Console.WriteLine("Enter Day");
                    day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Month");
                    month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Year");
                    year = Convert.ToInt32(Console.ReadLine());

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
                            Console.WriteLine("Working day");
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid year");
                    }
                    Console.ResetColor();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Do you want to check other year? yes/no");
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
