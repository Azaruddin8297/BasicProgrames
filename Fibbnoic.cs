using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Fibbnoic
    {
        public static void call()
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            int i;


            Console.WriteLine("enter the number of elements");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2 + " ");
            for (i = 2; i < num; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;

            }
        }
    }
}
