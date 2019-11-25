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
}

