using System;

namespace RPSSpock
{
  class Program
  {
    static void Main(string[] args)
    {

      /*
         - As a user, I should see a welcome message.
         - As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
         - The computer should randomly decide one of the options.
         - You program should then decide who the winner is;
         - The user should then see the randomly selected option, as well as a win or lose message.
         - add some validation around user input.
      */

      //Code welcome message
      Console.WriteLine("Welcome to rock, paper scissors.");
      var computerChoice = "nothing";
      var winnerMessage = "nothing";
      Boolean playing = true;

      while (playing == true)
      {

        // Choose difficulty level and validation logic
        Console.WriteLine("Please choose a difficulty level:one of the following: normal, impossible and easy");
        var userDifficulty = Console.ReadLine().ToLower();

        Boolean difficultySelected = false;

        while (difficultySelected == false)
        {
          if (userDifficulty == "normal" || userDifficulty == "impossible" || userDifficulty == "easy")
          {
            difficultySelected = true;
          }
          else
          {
            Console.WriteLine("Again moron...Please choose a difficulty level:one of the following: normal, impossible and easy");
            userDifficulty = Console.ReadLine().ToLower();
          }

        }

        Console.WriteLine("Please choose one of the following: rock, paper or scissor");

        var userChoice = Console.ReadLine().ToLower();

        Boolean good = false;

        while (good == false)
        {
          if (userChoice == "rock" || userChoice == "paper" || userChoice == "scissor")
          {
            good = true;
          }
          else
          {
            Console.WriteLine("Again...Please choose one of the following: rock, paper or scissor");
            userChoice = Console.ReadLine().ToLower();
          }
        }

        Console.WriteLine("Thank you.  You have selected " + userChoice);

        switch (userDifficulty)
        {

          case "impossible":
            Console.WriteLine("You chose Impossible");

            switch (userChoice)
            {
              case "rock":
                computerChoice = "paper";
                break;

              case "paper":
                computerChoice = "scissor";
                break;

              default:
                computerChoice = "rock";
                break;
            }
            break;

          case "easy":
            Console.WriteLine("Easy");

            switch (userChoice)
            {
              case "rock":
                computerChoice = "scissor";
                break;

              case "paper":
                computerChoice = "rock";
                break;

              default:
                computerChoice = "paper";
                break;
            }
            break;

          default:
            Console.WriteLine("Normal");

            // Testing
            //userChoice = "rock";

            // This is where we use the level



            //var computerChoice = new Random();

            Random rnd = new Random();
            string[] gameChoice = { "rock", "paper", "scissor" };
            int mIndex = rnd.Next(gameChoice.Length);
            Console.WriteLine("I selected {0}", gameChoice[mIndex]);
            computerChoice = gameChoice[mIndex];
            break;










            // end pick level

        }
        if (userChoice == computerChoice)
        {
          winnerMessage = "we tied.";
        }

        if (userChoice == "rock")
        {
          if (computerChoice == "scissor")
          {
            winnerMessage = "you win.";
          }
          else if (computerChoice == "paper")
          {
            winnerMessage = "I win.";
          }
        }

        if (userChoice == "paper")
        {
          if (computerChoice == "scissor")
          {
            winnerMessage = "I win.";
          }
          else if (computerChoice == "rock")
          {
            winnerMessage = "you win.";
          }
        }

        if (userChoice == "scissor")
        {
          if (computerChoice == "rock")
          {
            winnerMessage = "I win.";
          }
          else if (computerChoice == "paper")
          {
            winnerMessage = "you win.";
          }
        }

        Console.WriteLine("Based on your choice of " + userChoice + " and my choice of " + computerChoice + ", " + winnerMessage);

        Console.WriteLine("Dow you want to play again? Yes or No");
        var playAgain = Console.ReadLine().ToLower();

        if (playAgain == "yes")
        {
          playing = true;
        }
        else if (playAgain == "no")
        {
          playing = false;
          Console.Write("Thank you for playing");
        }

      }
    }
  }
}
