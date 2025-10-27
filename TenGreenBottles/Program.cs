// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

Console.WriteLine("This is the ten green bottles song!");
Console.WriteLine("     ");

bool playAgain = true;

while (playAgain == true)
{
    Console.WriteLine("What is the number of green bottles you want to start with?");
    int num = Convert.ToInt32(Console.ReadLine()!);
    Console.WriteLine("     ");

    for (int i = num; i > 0; i--)
    {
        if (i == 2)
        {
            Console.WriteLine($"There are {i} green bottles hanging on the wall,");
            Console.WriteLine($"There are {i} green bottles hanging on the wall,");
            Console.WriteLine("And if one green bottle would accidentally fall,");
            Console.WriteLine("There is 1 green bottle hanging on the wall.");
            Console.WriteLine();
        }
        else if (i > 1)
        {
            Console.WriteLine($"There are {i} green bottles hanging on the wall,");
            Console.WriteLine($"There are {i} green bottles hanging on the wall,");
            Console.WriteLine("And if one green bottle would accidentally fall,");
            Console.WriteLine($"There'll be {i - 1} green bottles hanging on the wall.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"There is {i} green bottle hanging on the wall,");
            Console.WriteLine($"There is {i} green bottle hanging on the wall,");
            Console.WriteLine("And if one green bottle would accidentally fall,");
            Console.WriteLine("There are no green bottles hanging on the wall!");
        }
    }

    Console.WriteLine("     ");
    Console.WriteLine("Do you want to play again? (yes/no)");
    string answer = Console.ReadLine()!;
    if (answer.ToLower() != "yes" && answer.ToLower() != "y")
    {
        playAgain = false;
    }
}
