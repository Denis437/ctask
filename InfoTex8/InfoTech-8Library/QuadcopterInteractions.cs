using System;
using System.Threading;
using System.Linq;

namespace InfoTech8
{
    public abstract class QuadcopterInteractions : AbstractEntity
    {
        protected long work = 0;
        private object owner;

        public int Progress { get { return (int)Math.Max(0, 100 - work); } }

        public event Action<object> ProgressEvent; 

        public QuadcopterInteractions() : base("", 100)
        {
            var rnd = new Random();
            var rndName = string.Join("", Enumerable.Range(1, 4).Select(x => rnd.Next(64, 90)).Select(x => (char)x));
            Name = rndName;
        }

        protected override void Run()
        {
            if (Interlocked.Read(ref work) != 0)
            {
                Repairing();
                ProgressEvent?.Invoke(owner);
            }
        }

        protected void Request(object owner)
        {
            this.owner = owner;
        }
        protected abstract void Repairing();
    }
}
