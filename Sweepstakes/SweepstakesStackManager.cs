using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {

        Stack<Sweepstakes> manager = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            manager.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return manager.Pop();
        }
    }
}
