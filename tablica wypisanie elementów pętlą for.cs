﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    class Program
    {

        static void Main(string[] args)
        {           
            int[] uczestnicy = { 19, 34, 23, 54, 31 };
            int i = 0;
            do
            {
                Console.WriteLine(uczestnicy[i]);
                i++;
            } while (i < 5);
            Console.ReadKey();
        }
    }
}