using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("dictionary sweepstakes");
            Contestant contestantWinner;

            sweepstakes.RegisterContestant(new Contestant());
            sweepstakes.RegisterContestant(new Contestant());
            sweepstakes.RegisterContestant(new Contestant());
            sweepstakes.RegisterContestant(new Contestant());

            //Contestant winner = sweepstakes.PickWinner();
            //sweepstakes.PrintContestantInfo(winner);
            sweepstakes.PrintAllContestantInfo();
            contestantWinner = sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestantWinner);
            Console.ReadLine();

        }


    }
}
