namespace Cpsc370Final;

public class Hangman
{
    public string guessProgress { get; private set; }
    private GuessManager guessManager;
    private PlayerTurns playerTurns;

    public Hangman(GuessManager guessManager, PlayerTurns playerTurns)
    {
        this.guessManager = guessManager;
        this.playerTurns = playerTurns;
    }
    public string DisplayStatus(int remainingGuesses)
    {
        string result = "";
        result = result + DrawHangman(remainingGuesses) + "\n";
        result = result + DisplayGuessProgress() + "\n";
        result = result + DisplayIncorrectGuesses() + "\n";
        return result;
    }

    private string DisplayIncorrectGuesses()
    {
        string result = "Your incorrect guesses are: ";
        if (guessManager.incorrectGuesses == null)
        {
            return result;
        }
        foreach (char guess in guessManager.incorrectGuesses)
        {
            result = result + guess + " ";
        }
        return result;
    }

    private string DrawHangman(int remainingAttemps)
    {
        switch (remainingAttemps)
        {
            case 0 :
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t |\n\t|       / \\\n\t|\n\t|\n________|_________";
            case 1 :
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t |\n\t|       / \n\t|\n\t|\n________|_________";
            case 2:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t |\n\t|        \n\t|\n\t|\n________|_________";
            case 3:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\\\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 4:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/|\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 5:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t/\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 6:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_x)\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 7:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x_ )\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 8:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (x  )\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 9:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      (   )\n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
            case 10:
                return "\t_________\n\t|\t |\n\t|        |\n\t|      \n\t|\t\n\t|\t \n\t|        \n\t|\n\t|\n________|_________";
        }
        return "";
    }

    public string DisplayGuessProgress()
    {
        List<char> guesses = guessManager.guessedLetters;
        string mysteryWord = playerTurns.mysteryWord;
        guessProgress = "";

        foreach (char letter in mysteryWord)
        {
            if (guesses !=  null && guesses.Contains(letter))
            {
                guessProgress += letter;
            }
            else
            {
                guessProgress += "_ ";
            }
        }

        return guessProgress;
    }

}