using System;
using System.Collections.Generic;
using NUnit.Framework;
using Panacea2.NUnit.Data;
using Panacea2.NUnit.Utils;

// ReSharper disable InconsistentNaming

namespace Panacea2.NUnit
{
    [TestFixture]
    public sealed class AgeStringTests_ExternalData
    {
        [Test, TestCaseSource(typeof(AgeStringTests_ExternalData), nameof(LoadTests))]
        public void AS_is_created_properly(AgeStringTestData data)
        {
            string Act()
            {
                switch (data.Unit)
                {
                    case AgeStringTestUnit.Days:
                        return AgeString.FromDays(data.Input);

                    case AgeStringTestUnit.Weeks:
                        return AgeString.FromWeeks(data.Input);

                    case AgeStringTestUnit.Months:
                        return AgeString.FromMonths(data.Input);

                    case AgeStringTestUnit.Years:
                        return AgeString.FromYears(data.Input);

                    default:
                        throw new InvalidOperationException();
                }
            }

            if (data.Exception)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Act());
            }
            else
            {
                var actual = Act();
                Assert.That(actual, Is.EqualTo(data.Expected));
            }
        }

        private static IEnumerable<TestCaseData> LoadTests()
        {
            return JsonTestCaseReader.ReadTests<AgeStringTestData>(@"Data\AgeStringTestData.json");
        }
    }
}