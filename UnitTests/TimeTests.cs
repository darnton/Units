using System;
using Xunit;
using Darnton.Units;

namespace UnitTests
{
    public class TimeTests
    {
        private static DateTimeOffset UnixEpoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        [Fact]
        public void ConvertSecondsAsIntToTicks()
        {
            int elapsedSeconds = 10;
            var result = elapsedSeconds.FromSeconds();

            Assert.Equal(100.Million(), result);
        }

        [Fact]
        public void ConvertSecondsAsLongToTicks()
        {
            long elapsedSeconds = 10;
            var result = elapsedSeconds.FromSeconds();

            Assert.Equal(100.Million(), result);
        }

        [Fact]
        public void ConvertUnixTimeZeroToDateTimeOffset()
        {
            long elapsedSeconds = 0;
            var result = elapsedSeconds.FromUnixTime().ToDateTimeOffset();

            Assert.Equal(UnixEpoch, result);
        }

        [Fact]
        public void ConvertUnixBillenniumToDateTimeOffset()
        {
            long elapsedSeconds = 1000000000;
            var billenniumDateTimeOffset = new DateTimeOffset(2001, 9, 9, 1, 46, 40, TimeSpan.Zero);
            var result = elapsedSeconds.FromUnixTime().ToDateTimeOffset();

            Assert.Equal(billenniumDateTimeOffset, result);
        }
    }
}
