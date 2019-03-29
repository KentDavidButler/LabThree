using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Validation
    {
        public static bool BetweenOneAndHundo(int num, string name)
        {
            if (num > 100)
            {
                Console.WriteLine(name + ", Please type a number less than 100.");
                return false;
            }
            else if (num < 1)
            {
                Console.WriteLine(name + ", Please type a number greater than zero.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool YorN(string answer)
        {
            if (String.Equals("n", answer) || String.Equals("y", answer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
