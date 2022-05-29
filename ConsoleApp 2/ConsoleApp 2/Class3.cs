﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_2
{
    class PropertiesInClass
    {
        public PropertiesInClass(double r)
        {
            _radius = r;
        }
        private double _radius;
        private const double _pi = 3.14;
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void PrintCircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }
    }

    class Class3
    {
        public static void Main3()
        {
            PropertiesInClass p = new PropertiesInClass(2.5);
            Console.WriteLine("Radius is " + p.radius);
            p.PrintCircumference();
            ;
        }
    }
}
