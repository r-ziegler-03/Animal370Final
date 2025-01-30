namespace Cpsc370Final.Tests;
using Cpsc370Final;

public class GuessManager_Tests
{
    [Fact]
    public void GuessLetterTest()
    {
        GuessManager manager = new GuessManager("apple");
        
        bool result = GuessManager.GuessLetter("A");
        
        Assert.True(result);
    }

    [Theory]
    [InlineData("a")]
    public void TestForValidGuess(string guess)
    {
        GuessManager manager = new GuessManager("apple");
        bool result = GuessManager.IsValidGuess(guess);
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
        GuessManager manager = new GuessManager("apple");
        GuessManager.GuessLetter("b");
        bool result = GuessManager.IsValidGuess(guess);
        Assert.False(result);
    }
}