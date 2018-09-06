
// ReSharper disable InconsistentNaming

using System;
using Xunit;

namespace Panacea2.XUnit
{
    public sealed class WorkerTests_Contoso_Parallel
    {
        private static readonly Guid Item1 = Guid.Parse("164b84af-2a82-4316-983e-0ba7cc1f4887");
        private static readonly Guid Item2 = Guid.Parse("db2b4fa6-7a18-427e-81f4-6721f735c2cd");
        private static readonly Guid Item3 = Guid.Parse("7fc85722-d652-4e06-bec5-af72e0b2a022");

        [Fact]
        public void Empty_item_cannot_be_posted_to_Contoso()
        {
            var worker = new Worker();
            Assert.Throws<InvalidOperationException>(
                () => worker.PostToContoso(Guid.Empty));
        }

        [Fact]
        public void Item_1_can_be_posted_to_Contoso()
        {
            var worker = new Worker();
            var result = worker.PostToContoso(Item1);
            Assert.NotEqual(Item1, result);
        }

        [Fact]
        public void Item_2_can_be_posted_to_Contoso()
        {
            var worker = new Worker();
            var result = worker.PostToContoso(Item2);
            Assert.NotEqual(Item2, result);
        }

        [Fact]
        public void Item_3_can_be_posted_to_Contoso()
        {
            var worker = new Worker();
            var result = worker.PostToContoso(Item3);
            Assert.NotEqual(Item3, result);
        }
    }
}