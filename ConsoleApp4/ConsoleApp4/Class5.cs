using System;
using System.Collections.Generic;
using System.Text;

namespace CakeApp
{
    
    class Class5
    {
        static void Marin(string[] args)
        {
            ICake cup = new CupCake();
            ICake pinata = new PinataCake();
            var res1 = cup.getPrice("Vanilla", 2, 0.5);
            var res2 = pinata.getPrice("Chocolate", 2, 0.5);
            Console.WriteLine("" + res1);
            Console.WriteLine("" + res2);

        }
    }
    public iterface ICake
    {
        public double getPrice(string Flavour, int toppings, double sizeking);

    }
       public class CupCake:ICake
       {
    double pricekg;
    public double geeetPrice(string )

       }
}

