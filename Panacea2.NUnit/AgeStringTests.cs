using System;
using NUnit.Framework;

namespace Panacea2.NUnit
{
    [TestFixture]
    [Category("Unit"), Category("VR:AS")]
    public sealed class AgeStringTests
    {
        [Test]
        public void Cannot_create_AS_from_negative_days()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AgeString.FromDays(-1));
        }

        [Test]
        public void Cannot_create_AS_from_zero_days()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AgeString.FromDays(0));
        }

        [Test]
        public void Can_create_AS_for_1_day()
        {
            var actual = AgeString.FromDays(1);
            Assert.That(actual, Is.EqualTo("001D"));
        }

        [Test]
        public void Can_create_AS_for_days_between_1_and_9()
        {
            var actual = AgeString.FromDays(7);
            Assert.That(actual, Is.EqualTo("007D"));
        }
    }
}