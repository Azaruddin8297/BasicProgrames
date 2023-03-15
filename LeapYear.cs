using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LeapYear
    {
       public static void call()  {
            Console.WriteLine("Enter a 4 digit year ");
            string year = Console.ReadLine();
        int val = Convert.ToInt32(year);
            if (val % 4 == 0) {
                Console.WriteLine("its a leap year");
       
            }
            else
            {
                Console.WriteLine("its not a leap year");
            }
        }
    }
}
