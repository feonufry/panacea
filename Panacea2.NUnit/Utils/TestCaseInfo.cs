namespace Panacea2.NUnit.Utils
{
    public sealed class TestCaseInfo<T>
    {
        public string TestName { get; set; }
        public string[] TestCategories { get; set; }
        public string IgnoreReason { get; set; }
        public T TestCase { get; set; }
    }
}