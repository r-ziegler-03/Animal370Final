using Xunit.Abstractions;

namespace Cpsc370Final.Tests;

public class GuessManager_Tests
{
    [Fact]
    public void GuessLetterTest()
    {
        PlayerTurns testGame = new PlayerTurns();
        testGame.SetupGame("apple");
        bool result = testGame.guessManager.GuessLetter("A");
        Assert.True(result);
    }

    [Fact]
    public void TestForValidGuess()
    {
        PlayerTurns testGame = new PlayerTurns();
        bool result = testGame.guessManager.IsValidGuess("a");
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("Apple")]
    [InlineData("2")]
    [InlineData(" ")]
    [InlineData("g!")]
    [InlineData("!")]
    [InlineData("b")]
    public void TestForInvalidGuess(string guess)
    {
        PlayerTurns testGame = new PlayerTurns();
        testGame.SetupGame("apple");
        testGame.guessManager.GuessLetter("b");
        bool result = testGame.guessManager.IsValidGuess(guess);
        Assert.False(result);
    }
}