using Xunit.Abstractions;

namespace Cpsc370Final.Tests;

public class UnitTestWordGenerator
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTestWordGenerator(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void GeneratesWordForGame()
    {
        var random = new Random(0);
        var word = WordGenerator.GenerateWordForGame(random);
        Assert.Equal("pencil", word);
        
        _testOutputHelper.WriteLine(word);
    }
}