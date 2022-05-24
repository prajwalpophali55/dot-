using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        public static void Main(string[] args)
        {
            int i, j, m, n;
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];

            for(int r = 0; r <2; r++)
            {
                for(int c =0; c <2; c++)
                {
                    Console.WriteLine("Please Enter the value for arr1[" + r + "," + c + "]: ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int row =0; row <2; row++);

            {
                for (int col =0; col <2; col++);
                {
                    Console.WriteLine("Please enter the value for arr2[" + row +"," + col +"]:");
                        arr2[row , col]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine();
            for(i =0; i <2; i++)
            {
                for(j =0; j <2; i++)
                {
                    arr3[i, j] = 0;
                    for(int k =0; k <2; k++)
                    {
                        arr3[i, j] + = arr1[i, k] * arr2[k, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Multiplication Of Matrix is:");
            Console.WriteLine();
            for(i =0; i <2; i++)
            {
                for(j =0; j <2; i++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.Readline();
            }
        }
    }
}
