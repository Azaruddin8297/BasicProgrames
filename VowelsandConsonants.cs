﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
     public class VowelsandConsonants
    {
        public static void checkVowelsandConsonants()
        {
            Console.WriteLine("Enter any Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch =='a' || ch =='e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch +"Enterd charcter is Vowels"); 
            }
            else if((ch >= 'a' && ch<='z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is consonants");
            }
        }
    }
}
