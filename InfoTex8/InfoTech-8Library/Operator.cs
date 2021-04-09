using System.Threading;

namespace InfoTech8
{
    public class Operator : QuadcopterInteractions
    {
        protected override void Repairing()
        {
            Interlocked.Add(ref work, -1);
        }

        internal void RequestOperator()
        {
            Interlocked.Add(ref work, 100);
        }
    }
}
