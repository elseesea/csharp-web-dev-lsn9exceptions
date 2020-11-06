﻿using System;

namespace TemperatureExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature insideTemp = new Temperature(73);
            Console.WriteLine(insideTemp.Fahrenheit);

            Temperature outsideTemp = new Temperature(-8200);
            Console.WriteLine(outsideTemp.Fahrenheit);
        }

    } // class
} // namespace
