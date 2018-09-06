using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace Panacea2.XUnit
{
    [Trait("Category", "Unit")]
    [Trait("Subcategory", "VR:AS")]
    public sealed class AgeStringTests
    {
        [Fact]
        public void Cannot_create_AS_from_negative_days()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AgeString.FromDays(-1));
        }

        [Fact]
        public void Cannot_create_AS_from_zero_days()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AgeString.FromDays(0));
        }

        [Fact]
        public void Can_create_AS_for_1_day()
        {
            var actual = AgeString.FromDays(1);
            Assert.Equal("001D", actual);
        }

        [Fact]
        public void Can_create_AS_for_days_between_1_and_9()
        {
            var actual = AgeString.FromDays(7);
            Assert.Equal("007D", actual);

            /*using (var file = File.OpenText(@"Data\AgeStringTestData.json"))
            {
                file.Should().NotBeNull();
                file.BaseStream.Should().NotBeNull();
                file.BaseStream.CanRead.Should().BeFalse();
            }*/
        }
    }
}