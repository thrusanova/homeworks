﻿//The gravitational field of the Moon is approximately  17%  of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
 class GravitationOnTheMoon
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = weight * 0.17;
            Console.WriteLine(weightOnTheMoon);
        }
    }
