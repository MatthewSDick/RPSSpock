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
      Console.WriteLine("Please choose one of the following: rock, paper or scissor");

      var userChoice = Console.ReadLine().ToLower();

      Boolean good = false;


      while (good == false)
      {
        if (userChoice == "rock")
        {
          good = true;
        }
        else if (userChoice == "paper")
        {
          good = true;
        }
        else if (userChoice == "scissor")
        {
          good = true;
        }
        else
        {
          Console.WriteLine("Again...Please choose one of the following: rock, paper or scissor");
          userChoice = Console.ReadLine().ToLower();

        }
      }

      // Testing
      //userChoice = "rock";

      Console.WriteLine("Thank you.  You have selected " + userChoice);

      //var computerChoice = new Random();

      Random rnd = new Random();
      string[] gameChoice = { "rock", "paper", "scissor" };
      int mIndex = rnd.Next(gameChoice.Length);
      Console.WriteLine("I selected {0}", gameChoice[mIndex]);

      var winnerMessage = "nothing";

      if (userChoice == gameChoice[mIndex])
      {
        winnerMessage = "we tied.";
      }

      if (userChoice == "rock")
      {
        if (gameChoice[mIndex] == "scissor")
        {
          winnerMessage = "you win.";
        }
        else if (gameChoice[mIndex] == "paper")
        {
          winnerMessage = "I win.";
        }
      }

      if (userChoice == "paper")
      {
        if (gameChoice[mIndex] == "scissor")
        {
          winnerMessage = "I win.";
        }
        else if (gameChoice[mIndex] == "rock")
        {
          winnerMessage = "you win.";
        }
      }

      if (userChoice == "scissor")
      {
        if (gameChoice[mIndex] == "rock")
        {
          winnerMessage = "I win.";
        }
        else if (gameChoice[mIndex] == "paper")
        {
          winnerMessage = "you win.";
        }
      }

      Console.WriteLine("Based on your choice of " + userChoice + " and my choice of " + gameChoice[mIndex] + ", " + winnerMessage);

    }
  }
}
