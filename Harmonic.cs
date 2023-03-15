using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Harmonic
    {
        public static void Call()
        {
            Console.WriteLine("Please Enter The Number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Entered value is not Harmonic, it shouldnt be Zero");

            }
            else
            {
                double sum = 0.0;
                for (int i = 1; i <= n; i++)
                {
                    sum = (sum + 1.0) / i;
                    Console.WriteLine("The " + i + "the Harmonic number is :");
                    Console.WriteLine("1.0 /" + i + "=" + sum);
                }

            }
        }
        }
}
