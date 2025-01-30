namespace Cpsc370Final;

public class WinChecker
{
    public bool Win;

    
    //TODO: get the variables listed as parameters from the other classes and substitute appropriately 
    public bool winState(string guessedWord, String randomWord, int gameMode, int lives)
    {
        if(gameMode == 0) {
            if (new string(guessedWord) == randomWord)
            {
                Console.WriteLine("Guesser won!");
                Win = true;
                return Win;
            }

            if (lives <= 0)
            {
                Console.WriteLine("Guesser lost!");
                Win = false;
                return Win;
            }
        } else if (gameMode == 1)
        {
            if (new string(guessedWord) == randomWord)
            {
                Console.WriteLine("You won!");
                Win = true;
                return Win;
            }

            if (lives <= 0)
            {
                Console.WriteLine("You lost!");
                Win = false;
                return Win;
            }
        }

        Win = false;
        return Win;
    }
}