using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class OddandEven
    {
        public static void oddoreven()
        {
            Console.WriteLine("Please Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("You have Entered Even Number");
            }
            else
            {
                Console.WriteLine("you have Entered Odd Number");
            }
        }
    }
}
