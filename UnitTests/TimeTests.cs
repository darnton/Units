using System;
using Xunit;
using Darnton.Units;

namespace UnitTests
{
    public class TimeTests
    {
        private static DateTimeOffset UnixEpoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        [Fact]
        public void ConvertUnixTimeZeroToDateTimeOffset()
        {
            long elapsedSeconds = 0;
            var result = elapsedSeconds.FromUnixTime().ToDateTimeOffset();

            Assert.Equal(UnixEpoch, result);
        }

        [Fact]
        public void ConvertUnixBilleniumToDateTimeOffset()
        {
            long elapsedSeconds = 1000000000;
            var billeniumDateTimeOffset = new DateTimeOffset(2001, 9, 9, 1, 46, 40, TimeSpan.Zero);
            var result = elapsedSeconds.FromUnixTime().ToDateTimeOffset();

            Assert.Equal(billeniumDateTimeOffset, result);
        }
    }
}
