using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public int CurrentNumberOfContestants = 0;
        public string sweepstakes;
        public Dictionary<int, Contestant> contestantDictionary = new Dictionary<int, Contestant>();

        public Sweepstakes()
        {
            
        }
        public void RegisterContestant()
        {
            Contestant newContestant = new Contestant();
            CurrentNumberOfContestants++;
            newContestant.registrationNumber = CurrentNumberOfContestants;
            contestantDictionary.Add(CurrentNumberOfContestants, newContestant);
        }
        public void RegisterContestant(Contestant contestant)
        {

        }
        //public Contestant PickWinner()
        //{
        //    Console.WriteLine(contestantDictionary.Keys);

        //}
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The winner is contestant number {contestant.registrationNumber}:\n{contestant.firstName} {contestant.lastName}!");
        }
        public void PrintAllContestantInfo()
        {
            foreach (KeyValuePair<int, Contestant> pair in contestantDictionary)
            {
                Console.WriteLine($"Contestant:\nRegistration Number: {pair.Key}\nName: {pair.Value.firstName} {pair.Value.lastName}");
            }
        }

    }
}
