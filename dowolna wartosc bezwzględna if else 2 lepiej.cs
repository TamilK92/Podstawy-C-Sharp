﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sortowanie_babelkowe
{
    class Program
    {

        static void Main(string[] args)
        {
            String imie, nawisko, view;
            Console.WriteLine("podaj imię: \n");
            imie = Console.ReadLine();
            Console.WriteLine("podaj nazwisko: \n");
            nawisko = Console.ReadLine();
            view = imie + " " + nawisko;
            if (view.Length < 30)
            {
                Console.WriteLine("Imię i nazwisko to: \n{0}", view);
            }
            else
            {
                Console.WriteLine("podane dane są za długie:(");
            }
            Console.ReadKey();
        }
    }
}