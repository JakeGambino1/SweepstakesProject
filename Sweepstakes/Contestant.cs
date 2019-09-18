using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public int registrationNumber;
        public Contestant(string firstName, string lastName, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.registrationNumber = registrationNumber;
        }
    }
}
