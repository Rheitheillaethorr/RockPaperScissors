using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //GettingInfoFirstPlayer
            Console.WriteLine(GettingInfoFromPlayer());
            Console.WriteLine(RandomComputerAnswer());
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
                    return "rock";
                case 1:
                    return "paper";
                case 2:
                    return "scissors";
                default:
                    return RandomComputerAnswer();
            }
        }
        static void WhoWillWin(string playerAnswer, string computerAnswer)
        {
            if (playerAnswer == computerAnswer)
            {
                Console.WriteLine("DRAW!");
            }
            
        }

    }
}
