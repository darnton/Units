using System;

namespace Darnton.Units
{
    public static class Time
    {
        // Base unit: Ticks (1 tick = 100 nanoseconds)
        public const long UnixEpochTicks = 621355968000000000;
        private const long TicksPerSecond = 10000000;

        /// <summary>
        /// Converts from a Unix timestamp to the base unit (.NET ticks).
        /// </summary>
        /// <param name="unixTimestamp">The number of seconds since midnight on 1st January, 1970</param>
        /// <returns>The number of ticks represented by the timestamp</returns>
        public static long FromUnixTime(this long unixTime) => unixTime * TicksPerSecond + UnixEpochTicks;

        /// <summary>
        /// Creates a new DateTimeOffset structure representing the tick count.
        /// </summary>
        /// <param name="ticks">The number of ticks</param>
        /// <param name="offsetTicks">The time zone offset in ticks. Defaults to zero, representing UTC</param>
        /// <returns>A new DateTime structure</returns>
        public static DateTimeOffset ToDateTimeOffset(this long ticks, long offsetTicks = 0) => new DateTimeOffset(ticks, new TimeSpan(offsetTicks));
    }
}
