namespace Cpsc370Final;

public class PlayerTurns
{
    public string mysteryWord { get; private set; }
    public int playerLives { get;  set; }
    public bool IsCorrectGuess { get; private set; }
    public Hangman hangman { get; private set; }
    public GuessManager guessManager { get; private set; }
    public WinChecker winChecker { get; private set; }

    public PlayerTurns()
    {
        guessManager = new GuessManager(this);
        hangman = new Hangman(this.guessManager, this);
        winChecker = new WinChecker(this.hangman,this);
    }

    public void RunGame()
    {
        while (true)
        {
            Console.WriteLine(hangman.DisplayStatus(playerLives));
            string guess;
            do
            {
                Console.WriteLine("Enter your Guess: ");
                guess = Console.ReadLine();
            } while (!guessManager.IsValidGuess(guess));
            
            IsCorrectGuess = guessManager.GuessLetter(guess);
            if (!IsCorrectGuess)
            {
                playerLives--;
            }
            if (winChecker.IsGameOver())
            {
                return;
            }
        }
    }

    public void SetupGame(string word)
    {
        mysteryWord = word.ToLower();
        playerLives = 10;
    }
}