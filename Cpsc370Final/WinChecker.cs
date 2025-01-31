namespace Cpsc370Final;

public class WinChecker
{
    private Hangman hangman;
    private PlayerTurns playerTurns;

    public WinChecker(Hangman hangman, PlayerTurns playerTurns)
    { 
        this.hangman = hangman;
        this.playerTurns = playerTurns;
    }
    
    public bool IsGameOver()
    {
        
        if (hangman.DisplayGuessProgress() == playerTurns.mysteryWord)
        {
            Console.WriteLine("Guesser won! The word was: " + playerTurns.mysteryWord);
            return true;
        }

        if (playerTurns.playerLives <= 0)
        {
            Console.WriteLine(hangman.DisplayStatus(0));
            Console.WriteLine("Guesser lost! The word was: " + playerTurns.mysteryWord);
            return true;
        }
        return false;
    }
}