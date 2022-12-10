namespace GuessTheHiddenCharacter.Game.Services;

public class Display
{
    private static Display Instance = new Display();
    private Character[] Characters = new Character[3];

    private Display()
    {
    }

    public static Display GetInstance()
    {
        return Instance;
    }

    public void WrongGuess()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wrong Guess!");
        Console.ResetColor();
    }

    public void StartScreen()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("<> Guess the Hidden Character <>\n\n");
        Console.ResetColor();
    }

    public void GreetUser(string username)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("<> Guess the Hidden Character <>\n\n");
        Console.ResetColor();
        Console.WriteLine($"\nHello {username} :)\nWelcome to our \"Guess the Hidden Character\" Game.");
        Console.Write("\n\n\nClick enter to continue. ");
        Console.ReadKey();
    }

    public void DisplayOptions()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("<> Guess the Hidden Character <>\n\n");
        Console.ResetColor();
        Console.WriteLine("1. Start");
        Console.WriteLine("2. Instructions");
        Console.WriteLine("3. Quit");
        Console.Write("\n\n\n");
    }

    // Game Section
    public void DisplayCharacters(int count)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("<> Guess the Hidden Character <>\n\n");
        Console.ResetColor();

        // Logics for displaying random characters of N size
        var characters = new Characters().GetCharacters;
        var random = new Random();
        int[] savedNumber = new int[3] { 0, 0, 0 };

        for (int i = 1; i <= count; i++)
        {
            Last:
            int temp = random.Next(1, 11);
            for (int j = 0; j < 3; j++)
            {
                if (temp == savedNumber[j]) goto Last;
            }

            Characters[i - 1] = characters.First(ch => ch.Id == temp);
            Console.WriteLine(Characters[i - 1] + "\n");
            savedNumber[i - 1] = temp;
        }

        Console.Write("\n\nClick enter to start guessing. ");
        Console.ReadKey();
    }

    public void DisplayCharactersAttributes()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("<> Guess the Hidden Character <>\n\n");
        Console.ResetColor();

        var random = new Random().Next(0, 3);
        var result = Result.GetInstance();
        result.StoredName = Characters[random].Name!;
        Characters[random].Name = "___________";
        Console.WriteLine(Characters[random]);

        Console.Write("\n\n\n");
    }
    // Game End Section

    // Displaying Instructions for playing the game
    public void Instructions()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("<> Guess the Hidden Character <>\n\n");
        Console.ResetColor();
        Console.WriteLine("We will show you a group of characters and you need to familiarize them within your own time.");
        Console.WriteLine("After that, we will show some attributes of a character and you need to guess who that character is.");
        Console.WriteLine("You have 3 lives, after you consumed them, you'll lose. :(");
        Console.WriteLine("You can play as long as you want and your points will continue to increase. :D");
        Console.Write("\n\nClick enter to continue. ");
        Console.ReadKey();
    }

    public void QuittingScreen()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("<> Guess the Hidden Character <>\n\n");
        Console.ResetColor();
        Console.Write("Thanks for using our Application.");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(". :)");
        Console.Write("\n\n\n");
    }

    public void GameOver()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nGame Over!");
        Console.Write("Click anywhere to continue... ");
        Console.ReadKey();
        Console.ResetColor();
    }
}
