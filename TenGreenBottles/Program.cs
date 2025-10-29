
using System;
using System.Text;

Console.WriteLine("    ");
Console.WriteLine("This is the ten green bottles song!");

static string numBottles(int x)
{
    if (x == 1)
    {
        return "bottle";
    }
    else
    {
        return "bottles";
    }
    
}

bool playAgain = true;

while (playAgain == true)
{
    Console.WriteLine("   ");
    Console.WriteLine("What is the number of green bottles you want to start with?");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    for (int i = num; i > 0; i--)
    {
        Console.WriteLine(i + " green " + numBottles(i) + " hanging on the wall");
        Console.WriteLine(i + " green " + numBottles(i) + " hanging on the wall,");
        Console.WriteLine("And if one green bottle should accidentally fall,");
        Console.WriteLine("There'll be " + (i - 1) + " green " + numBottles(i - 1) + " hanging on the wall");
        Console.WriteLine("    ");
    }

    Console.WriteLine("Do you want to play again? (yes/no)");
    string answer = Console.ReadLine() ?? string.Empty;
    switch (answer.ToLower())
    {
        case "yes":
            playAgain = true;
            break;
        case "y":
            playAgain = true;
            break;
        default:
            playAgain = false;
            break;
    }

}

//This is how it works:

//The switch expression is evaluated once
//The value of the expression is compared with the values of each case
//If there is a match, the associated block of code is executed
//The break and default keywords will be described later in this chapter
