﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");

            int number = Convert.ToInt32(Console.ReadLine());

            long fact = GetFactorial(number);

            Console.WriteLine("{0} factorial is {1}", number, fact);

            Console.ReadKey();

        }



        private static long GetFactorial(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * GetFactorial(number - 1);

        }

    }
}
