using System;
using System.Collections;
using System.Collections.Generic;

namespace RPSSpock
{
  class Program
  {

    static string randomGenerator()
    {
      Random rnd = new Random();
      string[] gameChoice = { "rock", "paper", "scissor", "lizard", "spock" };
      int mIndex = rnd.Next(gameChoice.Length);
      Console.WriteLine("I selected {0}", gameChoice[mIndex]);
      return gameChoice[mIndex];
    }

    static string winner(string userChoice, string computerChoice)
    {
      var winnerMessage = "";

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

      winnerMessage = "Based on your choice of " + userChoice + " and my choice of " + computerChoice + ", " + winnerMessage;
      return winnerMessage;
    }

    class humanPlayer
    {
      public string Name { get; set; }
      private string choice = "";
      private int win = 0;
      private int loss = 0;
      private int tie = 0;

      public int Win
      {
        get { return win; }
        set { win = value; }
      }
      public int Loss
      {
        get { return win; }
        set { win = value; }
      }
      public int Tie
      {
        get { return win; }
        set { win = value; }
      }

    }

    class PCPlayer
    {
      private string choice = "";
      private int win = 0;
      private int loss = 0;
      private int tie = 0;

      public int Win
      {
        get { return win; }
        set { win = value; }
      }
      public int Loss
      {
        get { return win; }
        set { win = value; }
      }
      public int Tie
      {
        get { return win; }
        set { win = value; }
      }

    }

    static void Main(string[] args)
    {


      // humanPlayer Matt = new humanPlayer();
      // //Matt.newLoss(1);
      // Matt.Loss = 1;
      // int example = Matt.Loss;
      // Console.Write("Example = " + example);




      Console.WriteLine("Welcome to rock, paper scissors.");
      var computerChoice = "nothing";
      var winnerMessage = "nothing";
      Boolean playing = true;



      Console.Write("How many human players?");
      var numHumans = Console.ReadLine();

      int humans = 0;
      Boolean res = int.TryParse(numHumans, out humans);
      if (res == true)
      {
        Console.Write("Please enter a number");
      }





      var people = new List<humanPlayer>();
      for (int i = 0; i < humans; i++)
      {
        // Here you can give each person a custom name based on a number
        people.Add(new humanPlayer { Name = "Person #" + (i + 1) });
      }

      // int counter = 0;
      // while (counter < humans)
      // {

      //   //string player = "player" + counter;
      //   humanPlayer jghjhgjhgjh = new humanPlayer();
      //   counter ++;
      // }






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

        Console.WriteLine("Please choose one of the following: rock, paper, scissor, lizard or spock");

        var userChoice = Console.ReadLine().ToLower();

        Boolean good = false;

        while (good == false)
        {
          if (userChoice == "rock" || userChoice == "paper" || userChoice == "scissor" || userChoice == "lizard" || userChoice == "spock")
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


            // Random rnd = new Random();
            // string[] gameChoice = { "rock", "paper", "scissor" };
            // int mIndex = rnd.Next(gameChoice.Length);
            // Console.WriteLine("I selected {0}", gameChoice[mIndex]);

            computerChoice = randomGenerator();
            break;

        }

        winnerMessage = winner(userChoice, computerChoice);

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
