namespace Cpsc370Final.Tests;

public class PlayerTurns_Tests
{
    [Theory]
    [InlineData(1, "a_ _ _ _ ", "")]
    [InlineData(2, "app_ _ ", "")]
    [InlineData(3, "app_ _ ", "")]
    [InlineData(5, "app_ _ ", "f")]
    [InlineData(7, "app_ e", "f")]
    [InlineData(8, "app_ e", "fq")]
    [InlineData(9, "apple", "fq")]
    [InlineData(10, "apple", "fq")]
    public void RunGameTests(int inputs, string expectedGuessProgress, string expectedIncorrectGuesses)
    {
        List<string> testInput = new List<string>(){"A", "p", "a", "dd", "f", "2", "e", "q", "l", "x"};
        bool isCorrectGuessTest;
        PlayerTurns gameTest = new PlayerTurns();
        gameTest.SetupGame("apple");
        
        for (int i = 0; i < inputs;)
        {
            string guess;
            do
            {
                guess = testInput[i++];
            } while (i < inputs && !gameTest.guessManager.IsValidGuess(guess));
            
            isCorrectGuessTest = gameTest.guessManager.GuessLetter(guess);
            if (!isCorrectGuessTest)
            {
                gameTest.playerLives--;
            }
            if (gameTest.winChecker.IsGameOver())
            {
                break;
            }
        }

        string actualIncorrectGuesses = "";
        foreach (char letter in gameTest.guessManager.incorrectGuesses)
        {
            actualIncorrectGuesses += letter;
        }
        
        Assert.Equal(expectedGuessProgress, gameTest.hangman.guessProgress);
        Assert.Equal(expectedIncorrectGuesses, actualIncorrectGuesses);
    }
}
