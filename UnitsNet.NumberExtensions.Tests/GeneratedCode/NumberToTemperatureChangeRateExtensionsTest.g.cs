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

using UnitsNet.NumberExtensions.NumberToTemperatureChangeRate;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToTemperatureChangeRateExtensionsTests
    {
        [Fact]
        public void NumberToCentidegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(2), 2.CentidegreesCelsiusPerSecond());

        [Fact]
        public void NumberToDecadegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(2), 2.DecadegreesCelsiusPerSecond());

        [Fact]
        public void NumberToDecidegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(2), 2.DecidegreesCelsiusPerSecond());

        [Fact]
        public void NumberToDegreesCelsiusPerMinuteTest() =>
            Assert.Equal(TemperatureChangeRate.FromDegreesCelsiusPerMinute(2), 2.DegreesCelsiusPerMinute());

        [Fact]
        public void NumberToDegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromDegreesCelsiusPerSecond(2), 2.DegreesCelsiusPerSecond());

        [Fact]
        public void NumberToDegreesKelvinPerMinuteTest() =>
            Assert.Equal(TemperatureChangeRate.FromDegreesKelvinPerMinute(2), 2.DegreesKelvinPerMinute());

        [Fact]
        public void NumberToHectodegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(2), 2.HectodegreesCelsiusPerSecond());

        [Fact]
        public void NumberToKilodegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(2), 2.KilodegreesCelsiusPerSecond());

        [Fact]
        public void NumberToMicrodegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(2), 2.MicrodegreesCelsiusPerSecond());

        [Fact]
        public void NumberToMillidegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(2), 2.MillidegreesCelsiusPerSecond());

        [Fact]
        public void NumberToNanodegreesCelsiusPerSecondTest() =>
            Assert.Equal(TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(2), 2.NanodegreesCelsiusPerSecond());

    }
}
