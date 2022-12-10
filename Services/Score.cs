namespace GuessTheHiddenCharacter.Game.Services;

public class Score
{
    private static Score Instance = new Score();
    private int NumberScore { get; set; }

    private Score()
    {
    }

    public static Score GetInstance()
    {
        return Instance;
    }

    public void Increment()
    {
        NumberScore++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Score Increased! B)");
        Console.Write($"Your score is {NumberScore}! ");
        Console.ResetColor();
        Console.ReadKey();
    }

    public void Nullify()
    {
        NumberScore = 0;
    }
}
