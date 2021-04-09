using System.Threading;

namespace InfoTech8
{
    public class SlowTechnic : ITechnic
    {
        public void Repairing()
        {
            Thread.Sleep(10000);
        }
    }
}
