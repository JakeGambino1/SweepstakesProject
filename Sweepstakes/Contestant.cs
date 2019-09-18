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
        public Contestant()
        {
            firstName = UI.GetUserStringInput("Enter your first name");
            lastName = UI.GetUserStringInput("Enter your last name");
        }
    }
}
