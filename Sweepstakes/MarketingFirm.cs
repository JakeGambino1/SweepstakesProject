using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager sweepstakeOrder;

        public MarketingFirm(ISweepstakesManager sweepstakeOrder)
        {
            this.sweepstakeOrder = sweepstakeOrder;
        }
        public void CreateSweepstakes()
        {
            Sweepstakes newSweepstake = new Sweepstakes(UI.GetUserStringInput("name your sweepstakes"));
            sweepstakeOrder.InsertSweepstakes(newSweepstake);
        }
    }
}
