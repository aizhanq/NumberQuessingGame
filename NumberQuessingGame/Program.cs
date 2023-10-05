Random r = new Random();

int winNum = r.Next(1, 100);

bool win = false;

do
{
    Console.Write("Quess a number inbetween 0 and 100: ");
    string a = Console.ReadLine();
    int i = int.Parse(a);

    if (i > winNum)
    {
        Console.WriteLine("To high! Quess lower...");
    }
    else if (i < winNum)
    {
        Console.WriteLine("To low! Quess higher...");
    }
    else if (i == winNum)
    {
        Console.WriteLine("YOU WIN!");
        win = true;
    }
} while (win == false);

Console.WriteLine("Thank you for playing game!");
Console.WriteLine("Press any ley to finish.");
