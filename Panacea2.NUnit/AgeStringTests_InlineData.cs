using System;
using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Panacea2.NUnit
{
    [TestFixture]
    [Category("Unit"), Category("VR:AS")]
    public sealed class AgeStringTests_InlineData
    {
        [TestCase(1, "001D")]
        [TestCase(7, "007D")]
        [TestCase(23, "023D")]
        [TestCase(456, "456D")]
        [TestCase(999, "999D")]
        public void AgeString_is_created_from_days(int days, string expected)
        {
            var actual = AgeString.FromDays(days);
            Assert.That(actual, Is.EqualTo(expected), $"Invalid AS value. Expected is `{expected}`, while actual is `{actual}`.");
        }

        [TestCase(-1, TestName = "AS cannot be created for negative days number")]
        [TestCase(0, TestName = "AS cannot be created for zero days number")]
        [TestCase(1000, TestName = "AS cannot be created for days number above 999")]
        public void AgeString_is_not_created_from_invalid_days_number(int days)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AgeString.FromDays(days));
        }
    }
}
