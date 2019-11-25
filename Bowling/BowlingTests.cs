using System;
using Xunit;

    public class BowlingTests
    {
    [Fact]
    public void One_Miss_is_Zero_Points()
    {
        var rolls = "-";

        var score = 0;

        Assert.Equal(score, Bowling.Score(rolls));
    }
}

