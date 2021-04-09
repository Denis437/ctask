using System;
using System.Timers;

namespace InfoTech8
{
    public abstract class AbstractEntity
    {
        protected readonly Timer timer = new Timer();

        public string Name { get; set; }

        public event Action<string> ActorEvent;

        protected AbstractEntity(string name, uint ms)
        {
            Name = name;
            timer.Interval = ms;
            timer.AutoReset = true;
            timer.Elapsed += (object sender, ElapsedEventArgs e) => Run();
            timer.Start();
        }

        protected abstract void Run();

        protected void RaiseEvent(string eventDesc)
        {
            ActorEvent?.Invoke(eventDesc);
        }
    }
}
