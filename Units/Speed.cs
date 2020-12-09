using System;
using System.Collections.Generic;
using System.Text;

namespace Darnton.Units
{
    /// <summary>
    /// The Speed class contains extension methods for converting from
    /// one sped unit or format to another. The base unit for conversions
    /// is metres per second.
    /// </summary>
    public static class Speed
    {
        //Base unit: Metres per second
        private const decimal SecondsPerHour = 3600;
        private const decimal MetresPerKilometre = 1000;
        /// <summary>
        /// Converts from metres per second to the base unit (metres per second).
        /// The identity conversion, used to make source units explicit in the code.
        /// </summary>
        /// <param name="speed">The speed in metres per second.</param>
        /// <returns>The speed in metres per second.</returns>
        public static decimal FromMetresPerSecond(this int speed) => speed;
        /// <summary>
        /// Converts from metres per second to the base unit (metres per second).
        /// The identity conversion, used to make source units explicit in the code.
        /// </summary>
        /// <param name="speed">The speed in metres per second.</param>
        /// <returns>The speed in metres per second.</returns>
        public static decimal FromMetresPerSecond(this decimal speed) => speed;
        /// <summary>
        /// Converts from metres per second to kilometres per hour.
        /// </summary>
        /// <param name="speed">The speed in metres per second.</param>
        /// <returns>The speed in kilometres per hour.</returns>
        public static decimal ToKilometresPerHour(this decimal speed) => speed * SecondsPerHour / MetresPerKilometre;
    }
}
