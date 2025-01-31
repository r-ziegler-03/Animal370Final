namespace Cpsc370Final;

public class GuessManager
{
    public  List<char> guessedLetters { get; private set; }
    public  List<char> incorrectGuesses {get; private set;}
    
    private PlayerTurns playerTurns;

    public GuessManager(PlayerTurns playerTurns)
    {
        guessedLetters = new List<char>();
        incorrectGuesses = new List<char>();
        this.playerTurns = playerTurns;
    }

    public bool IsValidGuess(string guess)
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

    public bool GuessLetter(string guess)
    {
        char letter = char.ToLower(guess[0]);
        guessedLetters.Add(letter);
        if (!playerTurns.mysteryWord.Contains(letter))
        {
            incorrectGuesses.Add(letter);
            return false;
        }
        return true;
    }
}