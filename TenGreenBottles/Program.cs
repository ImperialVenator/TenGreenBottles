// TenGreenBottles.cs
using System;
using System.Text;

Console.WriteLine("This is the ten green bottles song!");

static string BottleBottles(int x)
{
    if (x == 1)
    {
        return "bottle";
    }
    return "bottles";
}

bool playAgain = true;

while (playAgain == true)
{
    Console.WriteLine("What is the number of green bottles you want to start with?");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    for (int i = num; i > 0; i--)
    {
        Console.WriteLine(i + " green " + BottleBottles(i) + " hanging on the wall");
        Console.WriteLine(i + " green " + BottleBottles(i) + " hanging on the wall,");
        Console.WriteLine("And if one green bottle should accidentally fall,");
        Console.WriteLine("There'll be " + (i - 1) + " green " + BottleBottles(i - 1) + " hanging on the wall");
    }

    Console.WriteLine("Do you want to play again? (yes/no)");
    string answer = Console.ReadLine();
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

