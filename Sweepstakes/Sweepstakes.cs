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

        public Sweepstakes(string sweepstakes)
        {
            this.sweepstakes = sweepstakes;
        }
        public void RegisterContestant(Contestant contestant)
        {
            CurrentNumberOfContestants++;
            contestant.registrationNumber = CurrentNumberOfContestants;
            contestantDictionary.Add(CurrentNumberOfContestants, contestant);
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            int winningNumber; 
            winningNumber = random.Next(1, CurrentNumberOfContestants + 1);

            foreach (KeyValuePair<int, Contestant> pair in contestantDictionary)
            {
                if (winningNumber == pair.Key)
                {
                    Console.WriteLine($"The winner is {pair.Value}");
                    return pair.Value;
                }
            }
            return null;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant Number: {contestant.registrationNumber}\nName:\n{contestant.firstName} {contestant.lastName}! They can be reached at {contestant.email}.");
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
