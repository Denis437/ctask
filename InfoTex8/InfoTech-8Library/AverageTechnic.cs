using System.Threading;

namespace InfoTech8
{
    public class AverageTechnic : ITechnic
    {
        public void Repairing()
        {
            Thread.Sleep(5000);
        }
    }
}
