
// ReSharper disable InconsistentNaming

using System;
using Xunit;

namespace Panacea2.XUnit
{
    public sealed class WorkerTests_Acme_Parallel
    {
        private static readonly Guid Item1 = Guid.Parse("164b84af-2a82-4316-983e-0ba7cc1f4887");
        private static readonly Guid Item2 = Guid.Parse("db2b4fa6-7a18-427e-81f4-6721f735c2cd");
        private static readonly Guid Item3 = Guid.Parse("7fc85722-d652-4e06-bec5-af72e0b2a022");

        [Fact]
        public void Empty_item_cannot_be_posted_to_ACME()
        {
            var worker = new Worker();
            Assert.Throws<InvalidOperationException>(
                () => worker.PostToAcme(Guid.Empty));
        }

        [Fact]
        public void Item_1_can_be_posted_to_ACME()
        {
            var worker = new Worker();
            var result = worker.PostToAcme(Item1);
            Assert.Equal(Item1, result);
        }

        [Fact]
        public void Item_2_can_be_posted_to_ACME()
        {
            var worker = new Worker();
            var result = worker.PostToAcme(Item2);
            Assert.Equal(Item2, result);
        }

        [Fact]
        public void Item_3_can_be_posted_to_ACME()
        {
            var worker = new Worker();
            var result = worker.PostToAcme(Item3);
            Assert.Equal(Item3, result);
        }
    }
}