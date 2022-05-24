using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main1(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Enter string");
            s = Console.ReadLine();
            for (int i = s.Length-1; i >0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);

            }
            else
            {
                Console.WriteLine("string is not palindrome \n Entered string was {0} and reverse string is {1}", s, revs);
            }
            Console.ReadLine();

        }
    }
}
