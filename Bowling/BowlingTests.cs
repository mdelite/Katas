using System;
using Xunit;

    public class BowlingTests
    {
        [Fact]
        public void not_a_pin_hit()
        {
            var game = "-- -- -- -- -- -- -- -- -- --";

            Assert.Equal(0, Bowling.GetScore(game));
        }
}

