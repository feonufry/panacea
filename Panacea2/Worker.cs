using System;
using System.Threading;
using JetBrains.Annotations;

namespace Panacea2
{
    [PublicAPI]
    public sealed class Worker
    {
        public Worker()
        {
            // Long initializing
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        public Guid PostToAcme(Guid item)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            if (item == Guid.Empty)
            {
                throw new InvalidOperationException();
            }
            return item;
        }

        public Guid PostToContoso(Guid item)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            if (item == Guid.Empty)
            {
                throw new InvalidOperationException();
            }
            return Guid.NewGuid();
        }
    }
}