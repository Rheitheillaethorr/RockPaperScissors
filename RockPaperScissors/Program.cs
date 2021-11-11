using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            WhoWillWin(GettingInfoFromPlayer(), RandomComputerAnswer());
        }
        static string GettingInfoFromPlayer()
        {
            string[] fighters = new string[] { "rock", "paper", "scissors" };
            Console.WriteLine("Choose your figther");
            Console.WriteLine("type: 'rock', 'paper' or 'scissors'");
            string firstPlayerChoice = Console.ReadLine();
            string check = Array.Find(fighters, element => element == firstPlayerChoice);
            if (check == firstPlayerChoice)
            {
                return firstPlayerChoice;
            }
            else
            {
                Console.WriteLine("It is wrong fighter! \nTry again!");
                return GettingInfoFromPlayer();
            }
        }
        static string RandomComputerAnswer()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(3);
            switch (RandomNumber)
            {
                case 0:
                    Console.WriteLine("Computer choose rock");
                    return "rock";
                case 1:
                    Console.WriteLine("Computer choose paper");
                    return "paper";
                case 2:
                    Console.WriteLine("Computer choose scissors");
                    return "scissors";
                default:
                    return RandomComputerAnswer();
            }
        }
        static void WhoWillWin(string playerAnswer, string computerAnswer)
        {
            if (playerAnswer == computerAnswer)
            {
                Console.WriteLine("Tie! Next round");
                WhoWillWin(GettingInfoFromPlayer(), RandomComputerAnswer());
            }
            else if (playerAnswer == "rock" && computerAnswer == "scissors" || playerAnswer == "scissors" && computerAnswer == "paper" || playerAnswer == "paper" && computerAnswer == "rock")
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost :(");
            }
            TryAgain();
        }
        static void TryAgain()
        {
            Console.WriteLine("Do you want to try again?\nType 'yes' for retry or anything else to quit program");
            string retryAnswer = Console.ReadLine();
            switch (retryAnswer)
            {
                case "yes":
                    WhoWillWin(GettingInfoFromPlayer(), RandomComputerAnswer());
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
