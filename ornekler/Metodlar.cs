using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekler
{
   
    internal class Metodlar
    {
     
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

    }
}
