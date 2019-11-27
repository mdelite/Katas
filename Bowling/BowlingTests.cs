using System;
using Xunit;

public class BowlingTests
{
    [Fact]
    public void not_a_pin_hit()
    {
        var game = "-- -- -- -- -- -- -- -- -- --";
        var sut = new Bowling(game);

        int expected = 0;

        Assert.Equal(expected, sut.Score);
    }

    [Fact]
    public void TestName()
    {
        var game = "9- 9- 9- 9- 9- 9- 9- 9- 9- 9-";
        var sut = new Bowling(game);

        Assert.Equal(90, sut.Score);
    }
}

