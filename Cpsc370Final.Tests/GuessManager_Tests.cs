using Xunit.Abstractions;

namespace Cpsc370Final.Tests;

public class GuessManager_Tests
{
    [Fact]
    public void GuessLetterTest()
    {
        PlayerTurns.SetupGame("apple");
        bool result = GuessManager.GuessLetter("A");
        Assert.True(result);
    }

    [Fact]
    public void TestForValidGuess()
    {
        bool result = GuessManager.IsValidGuess("a");
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
        PlayerTurns.SetupGame("apple");
        GuessManager.GuessLetter("b");
        bool result = GuessManager.IsValidGuess(guess);
        Assert.False(result);
    }
}