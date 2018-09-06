namespace Panacea2.XUnit
{
    public sealed class WorkerFixture
    {
        public Worker Worker { get; }

        public WorkerFixture()
        {
            Worker = new Worker();
        }
    }
}