namespace Cpsc370Final.Tests;

public class PlayerTurns_Tests
{
    [Theory]
    [InlineData(6, "apple")]
    [InlineData(7, "apple")]
    [InlineData(3, "app_ _ ")]
    public void RunGameTests(int inputs, string expected)
    {
        List<string> testInput = new List<string>(){"a", "p", "a", "dd", "l", "e", "f"};
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
        
        Assert.Equal(expected, gameTest.hangman.guessProgress);
        
    }
    
}
