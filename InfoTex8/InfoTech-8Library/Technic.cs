using System;
using System.Collections.Generic;
using System.Threading;

namespace InfoTech8
{
    public class Technic : QuadcopterInteractions
    {
        private static readonly List<Technic> instances = new List<Technic>();
        private readonly ITechnic technics; 
        private readonly SemaphoreSlim sem;

        public static Technic GetRandomTechnic() { 
            if (instances.Count == 0)
            {
                return null;
            }
            return instances[new Random().Next(0, instances.Count)];
        }

        public Technic(ITechnic loader)
        {
            technics = loader;
            sem = new SemaphoreSlim(1);
            instances.Add(this);
        }

        protected override void Repairing()
        {
            timer.Stop();
            RaiseEvent("Чинит GPS.");
            technics.Repairing();
            Interlocked.Add(ref work, -100);
            RaiseEvent("Отдыхает.");
            timer.Start();
            sem.Release();
        }

        internal void RequestTechnicRepairing(Quadcopter quadcopter)
        {
            sem.Wait();
            Request(quadcopter);
            Interlocked.Add(ref work, 100);
        }
    }
}
