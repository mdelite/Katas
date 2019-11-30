using System;
using Xunit;

public class BowlingTests
{
    [Theory]
    [InlineData("-- -- -- -- -- -- -- -- -- --",0)]
    [InlineData("X X X X X X X X X X X X",300)]
    [InlineData("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-",90)]
    [InlineData("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5",150)]
    [InlineData("x x x x x x x x x 23",252)]
    public void testing_different_scores(string game, int expectedScore)
    {
        var sut = new Bowling(game);

        Assert.Equal(expectedScore, sut.Score);
    }

}

