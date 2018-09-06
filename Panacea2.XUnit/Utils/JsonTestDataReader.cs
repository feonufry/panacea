using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Panacea2.XUnit.Utils
{
    public static class JsonTestDataReader
    {
        [NotNull, ItemNotNull]
        public static IEnumerable<object[]> ReadTests<T>([NotNull] string filePath)
        {
            var directory = Directory.GetCurrentDirectory();
            var text = File.ReadAllText(Path.Combine(directory, filePath));
            var testCases = JsonConvert.DeserializeObject<T[]>(text);
            foreach (var testCase in testCases)
            {
                yield return new object[] { testCase };
            }
        }
    }
}