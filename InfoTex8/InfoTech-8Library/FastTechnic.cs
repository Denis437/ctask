using System.Threading;

namespace InfoTech8
{
    public class FastTechnic : ITechnic
    {
        public void Repairing()
        {
            Thread.Sleep(1000);
        }
    }
}
