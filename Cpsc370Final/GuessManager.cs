namespace Cpsc370Final;

public class GuessManager
{
    private static List<char> guessedLetters;
    private static string mysteryWord;
    
    public GuessManager(string word)
    {
        guessedLetters = new List<char>();
        mysteryWord = word.ToLower();
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
        if (guessedLetters.Contains(letter))
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
        return (mysteryWord.Contains(letter));
    }

}