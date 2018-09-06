using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Panacea2.NUnit.Utils
{
    public static class JsonTestCaseReader
    {
        [NotNull, ItemNotNull]
        public static IEnumerable<TestCaseData> ReadTests<T>([NotNull] string filePath)
        {
            var text = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, filePath));
            var testCasesMetadata = JsonConvert.DeserializeObject<TestCaseInfo<T>[]>(text);
            foreach (var testCaseMetadata in testCasesMetadata)
            {
                var result = new TestCaseData(testCaseMetadata.TestCase).SetName(testCaseMetadata.TestName);
                foreach (var category in testCaseMetadata.TestCategories)
                {
                    result = result.SetCategory(category);
                }
                if (!string.IsNullOrEmpty(testCaseMetadata.IgnoreReason))
                {
                    result = result.Ignore(testCaseMetadata.IgnoreReason);
                }
                yield return result;
            }
        }
    }
}