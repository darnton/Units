using System;

namespace Darnton.Units
{
    /// <summary>
    /// The Time class contains extension methods for converting from
    /// one time unit or format to another. The base unit for conversions
    /// is the .NET tick, equal to 100 nanoseconds.
    /// </summary>
    public static class Time
    {
        // Base unit: Ticks (1 tick = 100 nanoseconds)
        private const long UnixEpochTicks = 621355968000000000;
        private static long TicksPerSecond = 10.Million();

        /// <summary>
        /// Converts a time in seconds to the base unit (.NET ticks).
        /// </summary>
        /// <param name="seconds">The number of seconds.</param>
        /// <returns>The numbers of ticks.</returns>
        public static long FromSeconds(this int seconds) => seconds * TicksPerSecond;

        /// <summary>
        /// Converts a time in seconds to the base unit (.NET ticks).
        /// </summary>
        /// <param name="seconds">The number of seconds.</param>
        /// <returns>The numbers of ticks.</returns>
        public static long FromSeconds(this long seconds) => seconds * TicksPerSecond;

        /// <summary>
        /// Converts from a Unix timestamp to the base unit (.NET ticks).
        /// </summary>
        /// <param name="unixTime">The number of seconds since midnight on 1st January, 1970.</param>
        /// <returns>The number of ticks represented by the timestamp.</returns>
        public static long FromUnixTime(this long unixTime) => unixTime * TicksPerSecond + UnixEpochTicks;

        /// <summary>
        /// Creates a new DateTimeOffset structure representing the tick count.
        /// </summary>
        /// <param name="ticks">The number of ticks.</param>
        /// <param name="offsetTicks">The time zone offset in ticks. Defaults to zero, representing UTC.</param>
        /// <returns>A new DateTimeOffset structure</returns>
        public static DateTimeOffset ToDateTimeOffset(this long ticks, long offsetTicks = 0) => new DateTimeOffset(ticks, new TimeSpan(offsetTicks));
    }
}
