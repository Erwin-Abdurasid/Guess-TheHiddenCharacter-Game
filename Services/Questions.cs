namespace GuessTheHiddenCharacter.Game.Services;

public class Questions
{
    private static Questions Instance = new Questions();

    private Questions()
    {
    }

    public static Questions GetInstance()
    {
        return Instance;
    }

    // Method for checking the string if all of its characters are valid
    private bool IsCharValid(string name)
    {
        foreach (var ch in name)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Name");
                Console.ResetColor();
                return false;
            }
        }

        return true;
    }
    private bool IsCharOnlyLetter(string name)
    {
        foreach (var ch in name)
        {
            if (!char.IsLetter(ch))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Name");
                Console.ResetColor();
                return false;
            }
        }

        return true;
    }

    // Method for asking the user name
    public string AskUserName()
    {
        var result = "";

        while (true)
        {
            Console.Write("\nWhat is your name, Dear User? ");
            result = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(result)) continue;
            if (!IsCharValid(result)) continue;
            break;
        }

        return result;
    }

    // Method for asking the user what action does he/she wanna do
    public int AskAction()
    {
        int result;

        while (true)
        {
            Console.Write("Choose action by clicking its number. ");
            var temp = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(temp)) continue;
            if (int.TryParse(temp, out result) && result < 4 && result > 0)
                break;
            continue;
        }
        
        return result;
    }

    // Asking the user to guess
    public string Guess()
    {
        var result = "";

        while (true)
        {
            Console.Write("Guess the character! Type his/her name: ");
            result = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(result)) continue;
            if (!IsCharOnlyLetter(result)) continue;
            break;
        }

        return result;
    }

    public char DoPlayAgain()
    {
        Console.Write("Play again? ('Y' to play again) ");
        var temp = Console.ReadKey();
        if (temp.Key == ConsoleKey.Enter) return ' ';
        if (temp.Key == ConsoleKey.Y) return temp.KeyChar;

        return 'N';
    }
}
