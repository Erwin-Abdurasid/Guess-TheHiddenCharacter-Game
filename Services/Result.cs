namespace GuessTheHiddenCharacter.Game.Services;

public class Result
{
    private static Result Instance = new Result();

    private Result()
    {
    }

    public static Result GetInstance()
    {
        return Instance;
    }

    public string? StoredName { get; set; }
}
