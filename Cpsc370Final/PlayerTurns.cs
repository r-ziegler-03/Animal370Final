namespace Cpsc370Final;

public class PlayerTurns
{
    public static string mysteryWord { get; private set; }
    public static int playerLives { get; private set; }
    public static bool IsCorrectGuess { get; private set; }

    public static void RunGame()
    {
        while (true)
        {
            Console.WriteLine(Hangman.DisplayStatus(playerLives));
            string guess;
            do
            {
                Console.WriteLine("Enter your Guess: ");
                guess = Console.ReadLine();
            } while (!GuessManager.IsValidGuess(guess));
            
            IsCorrectGuess = GuessManager.GuessLetter(guess);
            if (!IsCorrectGuess)
            {
                playerLives--;
            }
            if (WinChecker.IsGameOver())
            {
                return;
            }
        }
    }

    public static void SetupGame(string word)
    {
        mysteryWord = word.ToLower();
        playerLives = 10;
    }
}