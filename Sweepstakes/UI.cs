using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UI
    {
        public static string userStringInput;
        public static int userNumberInput;
        public static string GetUserStringInput(string questionAsked)
        {
            Console.WriteLine(questionAsked);
            userStringInput = Console.ReadLine();
            return userStringInput;
        }
        public static int GetUserNumberInput(string questionAsked)
        {
            Console.WriteLine(questionAsked);
            userNumberInput = Convert.ToInt32(Console.ReadLine());
            return userNumberInput;
        }
    }
}
