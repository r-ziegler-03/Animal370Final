using Xunit.Abstractions;

namespace Cpsc370Final.Tests;

public class WordGenerator_Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public WordGenerator_Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void GeneratesWordForGame()
    {
        var random = new Random(0);
        WordGenerator test = new WordGenerator();
        var word = test.GenerateWordForGame(random);
        Assert.Equal("pencil", word);
        
        _testOutputHelper.WriteLine(word);
    }
}