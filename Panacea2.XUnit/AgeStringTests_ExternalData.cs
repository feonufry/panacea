// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using Panacea2.XUnit.Data;
using Panacea2.XUnit.Utils;
using Xunit;

namespace Panacea2.XUnit
{
    [Trait("Category", "Unit")]
    [Trait("Subcategory", "VR:AS")]
    [Trait("Subcategory", "json")]
    public sealed class AgeStringTests_ExternalData
    {
        [Theory, MemberData(nameof(LoadTests))]
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
                Assert.Equal(data.Expected, actual);
            }
        }

        public static IEnumerable<object[]> LoadTests()
        {
            return JsonTestDataReader.ReadTests<AgeStringTestData>(@"Data\AgeStringTestData.json");
        }
    }
}