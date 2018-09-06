using System;
using JetBrains.Annotations;

namespace Panacea2
{
    [PublicAPI]
    public static class AgeString
    {
        [NotNull]
        public static string FromDays(int days)
        {
            if (days <= 0 || days > 999)
            {
                throw new ArgumentOutOfRangeException(nameof(days), $"Days value cannot be negative or greater than 999. Value is {days}");
            }
            return $"{days:000}D";
        }

        [NotNull]
        public static string FromWeeks(int weeks)
        {
            if (weeks <= 0 || weeks > 999)
            {
                throw new ArgumentOutOfRangeException(nameof(weeks), $"Weeks value cannot be negative or greater than 999. Value is {weeks}");
            }
            return $"{weeks:000}W";
        }

        [NotNull]
        public static string FromMonths(int months)
        {
            if (months <= 0 || months > 999)
            {
                throw new ArgumentOutOfRangeException(nameof(months), $"Months value cannot be negative or greater than 999. Value is {months}");
            }
            return $"{months:000}M";
        }

        [NotNull]
        public static string FromYears(int years)
        {
            if (years <= 0 || years > 999)
            {
                throw new ArgumentOutOfRangeException(nameof(years), $"Years value cannot be negative or greater than 999. Value is {years}");
            }
            return $"{years:000}Y";
        }
    }
}