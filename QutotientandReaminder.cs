using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class QutotientandReaminder
    {
        public static void FindQandR()
        {
            int divident = 61, divisor = 10;
            int remainder = divident % divisor;
            int Quotient = divident / divisor;
            Console.WriteLine("the divident is {0} and divisor is {1} ",divident, divisor);
            Console.WriteLine("The Qutient is {0} and Remainder is {1}", Quotient, remainder);
        }
    }
}
