namespace GuessTheHiddenCharacter.Game.Models;

public class User
{
    public string? UserName { get; set; }
    public int Lives { get; set; } = 3;

    public void DecrementLife()
    {
        Lives--;
    }

    public void DisplayLife()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        if (Lives == 3) Console.Write("Life: <3 <3 <3");
        else Console.Write($"Life: {(Lives == 2? "<3 <3" : "<3")}");
        Console.ResetColor();
        Console.ReadKey();
    }
}