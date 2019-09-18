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
            Sweepstakes sweepstakes = new Sweepstakes();

            sweepstakes.RegisterContestant();
            sweepstakes.RegisterContestant();
            sweepstakes.RegisterContestant();
            sweepstakes.RegisterContestant();

            //Contestant winner = sweepstakes.PickWinner();
            //sweepstakes.PrintContestantInfo(winner);
            sweepstakes.PrintAllContestantInfo();
            Console.ReadLine();
        }
    }
}
