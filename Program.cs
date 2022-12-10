var quest = Questions.GetInstance();
var output = Display.GetInstance();
var result = Result.GetInstance();
var score = Score.GetInstance();
var user = new User();

// Just for setting the screen up
output.StartScreen();

// Identifying User
user.UserName = quest.AskUserName();
var username = user.UserName;
output.GreetUser(username);

// Displaying and Making the User choose from among 3 Options
Options:
output.DisplayOptions();
var choice = quest.AskAction();

// When the user chooses 1, 2 or 3
switch (choice)
{
    // Start
    case 1:
        output.DisplayCharacters(3);
        output.DisplayCharactersAttributes();
        var answer = quest.Guess();
        if (answer == result.StoredName)
        {
            user.DisplayLife();
            score.Increment();
            Again1:
            var justPlay = quest.DoPlayAgain();
            if (char.IsWhiteSpace(justPlay))
                goto Again1;
            if (justPlay == 'Y' || justPlay == 'y') goto case 1;
        }
        else
        {
            while (user.Lives > 1)
            {
                output.WrongGuess();
                user.DecrementLife();
                user.DisplayLife();
                Again2:
                var justPlay = quest.DoPlayAgain();
                if (char.IsWhiteSpace(justPlay))
                    goto Again2;
                if (justPlay == 'Y' || justPlay == 'y') goto case 1;
                break;
            }
            output.GameOver();
            score.Nullify();
        }
        goto Options;
    // Instructions
    case 2:
        output.Instructions();
        goto Options;
    // Exit
    case 3:
        output.QuittingScreen();
        break;
}
