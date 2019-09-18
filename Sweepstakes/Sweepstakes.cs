using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public string sweepstakes;
        public Dictionary<int, string> contestantDictionary;
        public void RegisterContestant(Contestant contestant)
        {
            contestantDictionary.Add(contestant.registrationNumber, contestant.firstName + " " + contestant.lastName);
        }
        public Contestant PickWinner()
        {
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
