// See https://aka.ms/new-console-template for more information
Random randomChoice = new Random();
int compChoice = randomChoice.Next(1, 4);
bool gameLoop = true;

while (gameLoop)
{

    Console.WriteLine("Want to play rock, paper scissors?! If not that is too bad, we are playing. Throw up a sign");
    string userSign = Console.ReadLine().ToLower();
    if (userSign == "rock" && compChoice == 1)
    {
        Console.WriteLine("its a rock tie!");

    }
    else if (userSign == "rock" && compChoice == 2)
    {
        Console.WriteLine("Computer threw paper you lose");


    }
    else if (userSign == "rock" && compChoice == 3)
    {
        Console.WriteLine("Computer threw scissors you win");


    }
    if (userSign == "scissors" && compChoice == 1)
    {
        Console.WriteLine("Computer chose rock, you got rocked!");

    }
    else if (userSign == "scissors" && compChoice == 2)
    {
        Console.WriteLine("Computer threw paper you win!");


    }
    else if (userSign == "scissors" && compChoice == 3)
    {
        Console.WriteLine("Computer threw scissors you lose!");
    }
    if (userSign == "paper" && compChoice == 1)
    {
        Console.WriteLine("Computer chose rock, won");

    }
    else if (userSign == "paper" && compChoice == 2)
    {
        Console.WriteLine("Computer threw paper, its a tie!");


    }
    else if (userSign == "paper" && compChoice == 3)
    {
        Console.WriteLine("Computer threw scissors you lose!");
    }
    Console.WriteLine("Do you want to play again? type yes or no");
    string playAgain = Console.ReadLine().ToLower();
    if (playAgain == "no")
    {
        gameLoop = false;
    }


}




