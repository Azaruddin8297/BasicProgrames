using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Swap
    {
        public static void call()
        {
            int a = 10; int b = 20;

            Console.WriteLine("Before Swap a =" + a + "b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Before After a =" + a + "b = " + b);
        }
    }
}
