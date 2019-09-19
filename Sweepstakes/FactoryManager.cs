using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class FactoryManager
    {
        public ISweepstakesManager ChooseSweepstakesManagement()
        {
            string userInput;
            userInput = UI.GetUserStringInput("Would you like this to be in a queue 'q' or a 'stack'?");

            if (userInput == "q" || userInput == "s")
            {
                switch (userInput)
                {
                    case "q":
                        return new SweepstakesQueueManager();
                    case "s":
                        return new SweepstakesStackManager();
                }
            }
            Console.WriteLine("Please make a valid choice");
            return ChooseSweepstakesManagement();
        }
    }
}