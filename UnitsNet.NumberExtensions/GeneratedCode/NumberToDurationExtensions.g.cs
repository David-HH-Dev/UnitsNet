//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToDuration
{
    /// <summary>
    /// A number to Duration Extensions
    /// </summary>
    public static class NumberToDurationExtensions
    {
        /// <inheritdoc cref="Duration.FromDays(UnitsNet.QuantityValue)" />
        public static Duration Days<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromDays(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromHours(UnitsNet.QuantityValue)" />
        public static Duration Hours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromJulianYears(UnitsNet.QuantityValue)" />
        public static Duration JulianYears<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromJulianYears(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMicroseconds(UnitsNet.QuantityValue)" />
        public static Duration Microseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromMicroseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMilliseconds(UnitsNet.QuantityValue)" />
        public static Duration Milliseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromMilliseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMinutes(UnitsNet.QuantityValue)" />
        public static Duration Minutes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMonths30(UnitsNet.QuantityValue)" />
        public static Duration Months30<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromMonths30(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromNanoseconds(UnitsNet.QuantityValue)" />
        public static Duration Nanoseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromNanoseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromSeconds(UnitsNet.QuantityValue)" />
        public static Duration Seconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromSols(UnitsNet.QuantityValue)" />
        public static Duration Sols<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromSols(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromWeeks(UnitsNet.QuantityValue)" />
        public static Duration Weeks<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromWeeks(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromYears365(UnitsNet.QuantityValue)" />
        public static Duration Years365<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Duration.FromYears365(Convert.ToDouble(value));

    }
}
