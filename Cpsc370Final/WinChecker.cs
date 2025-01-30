namespace Cpsc370Final;

public class WinChecker
{
    
    public static bool IsGameOver()
    {
        
        if (Hangman.DisplayGuessProgress() == PlayerTurns.mysteryWord)
        {
            Console.WriteLine("Guesser won! The word was: " + PlayerTurns.mysteryWord);
            return true;
        }

        if (PlayerTurns.playerLives <= 0)
        {
            Console.WriteLine(Hangman.DisplayStatus(0));
            Console.WriteLine("Guesser lost! The word was: " + PlayerTurns.mysteryWord);
            return true;
        }
        return false;
    }
}