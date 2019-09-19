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
            //Contestant contestantWinner;

            sweepstakes.RegisterContestant(new Contestant());
            sweepstakes.RegisterContestant(new Contestant());
            sweepstakes.RegisterContestant(new Contestant());
            sweepstakes.RegisterContestant(new Contestant());

            //contestantWinner = sweepstakes.PickWinner();
            //sweepstakes.PrintContestantInfo(contestantWinner);
            sweepstakes.NotifyContestants(sweepstakes);
            Console.ReadLine();


        }
    }
}
