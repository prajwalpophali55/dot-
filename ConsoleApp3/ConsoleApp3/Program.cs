using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void sum()
        {
            int sum = 3 + 2;
            Console.WriteLine(sum);
        }
        public static void sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void sum(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine(sum);
        }
        public static void sum(string a, string b)
        {
            int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(sum);
        }
        public static void Main1()
        {
            sum();
            sum(3, 2, 3);
            sum(3, 2);
            sum("3", "2");
        }
    }
}
