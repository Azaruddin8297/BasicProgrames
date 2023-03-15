using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LargestNumber
    {
        public static void Largest()
        {
            int num1 , num2 , num3 ;
            Console.WriteLine("Enter the 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("The 1st Number is greatest Number");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is greatest Number");
                }
             
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is greatest Number");
            }
            else
            {
                Console.WriteLine("The 3rd Number is greatest Number");
            }
        }
    }
}
