using System;
using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Panacea2.NUnit
{
    // [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public sealed class WorkerTests_Contoso_Parallel
    {
        private static readonly Guid Item1 = Guid.Parse("164b84af-2a82-4316-983e-0ba7cc1f4887");
        private static readonly Guid Item2 = Guid.Parse("db2b4fa6-7a18-427e-81f4-6721f735c2cd");
        private static readonly Guid Item3 = Guid.Parse("7fc85722-d652-4e06-bec5-af72e0b2a022");

        [Test]
        public void Empty_item_cannot_be_posted_to_Contoso()
        {
            var worker = new Worker();
            Assert.That(
                () => worker.PostToContoso(Guid.Empty),
                Throws.InvalidOperationException);
        }

        [Test]
        public void Item_1_can_be_posted_to_Contoso()
        {
            var worker = new Worker();
            var result = worker.PostToContoso(Item1);
            Assert.That(result, Is.Not.EqualTo(Item1));
        }

        [Test]
        public void Item_2_can_be_posted_to_Contoso()
        {
            var worker = new Worker();
            var result = worker.PostToContoso(Item2);
            Assert.That(result, Is.Not.EqualTo(Item2));
        }

        [Test]
        public void Item_3_can_be_posted_to_Contoso()
        {
            var worker = new Worker();
            var result = worker.PostToContoso(Item3);
            Assert.That(result, Is.Not.EqualTo(Item3));
        }
    }
}