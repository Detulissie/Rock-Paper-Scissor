Console.WriteLine("Choose [r]ock [p]aper or [s]cissors:");
string rock = "Rock";
string paper = "Paper";
string scissors = "Scissors";
while (true)
{
   string playerMove = Console.ReadLine();
    if (playerMove == "r") playerMove = rock;
    else if (playerMove == "p") playerMove = paper;
    else if (playerMove == "s") playerMove = scissors;
    else if (playerMove == "End") break;
    else
    {
        Console.WriteLine("Invalid Input. Try again...");
        continue;
    }
    // test
    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);
    string computerMove = "";
    switch (computerRandomNumber)
    {
        case 1:
            computerMove = rock;
            break;
        case 2:
            computerMove = paper;
            break;
        case 3:
            computerMove = scissors;
            break;
    }
    Console.WriteLine($"The computer chose {computerMove} ");
    if ((playerMove == rock && computerMove == scissors) || (playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper)) Console.WriteLine("You win!");
    else if ((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock)) Console.WriteLine("You lose :(");
    else if ((playerMove == rock && computerMove == rock) || (playerMove == paper && computerMove == paper) || (playerMove == scissors && computerMove == scissors)) Console.WriteLine("This game is a draw.");
}