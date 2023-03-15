using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FlipCoin
    {
        public static void call()
        {
            int head = 0;
            int tail = 1;
            Console.WriteLine("press enter");
            Console.ReadLine();
            Random random = new Random();
           
            int Flip = random.Next(2);
            if (Flip == head)
            {
                Console.WriteLine("Head");
            }
            else
            {
                Console.WriteLine("Tail");
            }

        }
    }
}
