namespace Cpsc370Final;

public class GuessManager
{
    private static List<char> guessedLetters = new List<char>();
    private static List<char> incorrectGuesses = new List<char>();

    public GuessManager()
    {
        //guessedLetters = new List<char>();
        //incorrectGuesses = new List<char>();
    }

    public static bool IsValidGuess(string guess)
    {
        if (guess.Length != 1)
        {
            Console.WriteLine("Invalid Guess. Please guess one letter only.");
            return false;
        }
        char letter = guess.First();
        if (!char.IsLetter(letter))
        {
            Console.WriteLine("Invalid Guess. Please enter a letter.");
            return false;
        }
        if (guessedLetters != null && guessedLetters.Contains(letter))
        {
            Console.WriteLine("You've already guessed this letter. Please enter a new one.");
            return false;
        }
        return true;
    }

    public static bool GuessLetter(string guess)
    {
        char letter = char.ToLower(guess[0]);
        guessedLetters.Add(letter);
        if (!PlayerTurns.mysteryWord.Contains(letter))
        {
            incorrectGuesses.Add(letter);
            return false;
        }
        return true;
    }

    public static List<char> GetGuessedLetters()
    {
        return guessedLetters;
    }
    
    public static List<char> GetIncorrectGuesses()
    {
        return incorrectGuesses;
    }
}