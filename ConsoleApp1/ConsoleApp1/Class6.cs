using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class6
    {
        public static void Main7(string[] args)
        {
            Console.Write("Enter the firstname");
            string firstname = Console.ReadLine();
            Console.Write("Enter the lastname");
            string lastname = Console.ReadLine();
            Console.Write("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("hello mr." + firstname +" "+ lastname);
            Console.ReadLine();
            Console.Write("your age is" + age);
            Console.ReadLine();


        }
        

            
    }
}
