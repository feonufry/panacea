
using System;
using Xunit;

// ReSharper disable InconsistentNaming

namespace Panacea2.XUnit
{
    [Trait("Category", "Unit")]
    [Trait("Subcategory", "VR:AS")]
    public sealed class AgeStringTests_InlineData
    {
        [Theory]
        [InlineData(1, "001D")]
        [InlineData(7, "007D")]
        [InlineData(23, "023D")]
        [InlineData(456, "456D")]
        [InlineData(999, "999D")]
        public void AgeString_is_created_from_days(int days, string expected)
        {
            var actual = AgeString.FromDays(days);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1000)]
        public void AgeString_is_not_created_from_invalid_days_number(int days)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AgeString.FromDays(days));
        }
    }
}
