using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Factor
    {
        public static void call()
        {
            Console.WriteLine("Please enter a positive integer:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factors of {0} are:", n);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
                
            }

        }
    }
}
