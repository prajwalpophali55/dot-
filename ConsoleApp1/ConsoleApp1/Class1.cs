using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {  
       public static void Main(string[] args)
        {
            int[] myArray = new int[] { 0, 1, 6, 5, 8, 15, 2 };
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;

                }
                else if (i > second)
                    second = i;
            }

            {
                System.Console.WriteLine(second);
            }
            Console.ReadLine();

        }






    }
}
