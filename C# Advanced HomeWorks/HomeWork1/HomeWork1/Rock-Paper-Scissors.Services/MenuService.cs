using Rock_Paper_Scissors.Domain;
using Rock_Paper_Scissors.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rock_Paper_Scissors.Services
{
    public class MenuService
    {
        public void Play(User user, Computer computer)
        {
            List<string> ourGame = new List<string>();
            ourGame.Add("rock");
            ourGame.Add("paper");
            ourGame.Add("scissors");

            Console.WriteLine("===OPTIONS===");
            foreach (string options in ourGame)
            {
                Console.WriteLine(options);
            }

            Console.WriteLine("Enter the option");
            string option = Console.ReadLine();
            Console.WriteLine(option);
            var random = new Random();
            int app = random.Next(ourGame.Count);
            Console.WriteLine(ourGame[app]);


            if (ourGame.Contains(option))
            {
                if (option == ourGame[app])
                {
                    Console.WriteLine("No winner");
                    computer.CalcGames++;
                }
                else if (option == "rock" && ourGame[app] == "paper" || option == "paper" && ourGame[app] == "scissors" || option == "scissors" && ourGame[app] == "rock")
                {
                    Console.WriteLine("Winner is computer");
                    computer.Wins++;
                    computer.CalcGames++;
                }
                else if (option == "rock" && ourGame[app] == "scissors" || option == "scissors" && ourGame[app] == "paper" || option == "paper" && ourGame[app] == "rock")
                {
                    Console.WriteLine("The user is winner");
                    user.Wins++;
                    computer.CalcGames++;
                }
            }
            else
            {
                throw new Exception("The option is invalid");
            }
        }

        public void Stats(User user, Computer computer)
        {
            Console.WriteLine("User wins" + " " + user.Wins);

            Console.WriteLine("Computer wins"+ " " + computer.Wins);

            Console.WriteLine("User results in percentage");
            int perecentageResultWins = 100 * user.Wins / computer.CalcGames;
            int perecentageResultLoses = 100 - perecentageResultWins;
            Console.WriteLine($"All games {computer.CalcGames}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Wins {perecentageResultWins}%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Losses {perecentageResultLoses}%");
            Console.ResetColor();
        }

        public void Exit()
        {
            Environment.Exit(-1);
        }
    }
}
