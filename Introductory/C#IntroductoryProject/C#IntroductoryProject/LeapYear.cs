﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_IntroductoryProject
{
    internal class LeapYear
    {

        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 == 0 || year % 400 == 0)
                Console.WriteLine("{0}는 윤년", year);

            else
                Console.WriteLine("{0}는 평년", year);
        }

    }
}
