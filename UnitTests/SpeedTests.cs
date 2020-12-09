using Darnton.Units;
using Xunit;

namespace UnitTests
{
    public class SpeedTests
    {
        [Fact]
        public void ConvertMetresPerSecondToKilometresPerHour()
        {
            var speedInMetresPerSecond = 2;
            var result = speedInMetresPerSecond.FromMetresPerSecond().ToKilometresPerHour();

            Assert.Equal(7.2m, result);
        }
    }
}
