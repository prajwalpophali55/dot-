using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_2
{
    class sample
    {
        public int a;
    }
    class Employe
    {
        public string Name;
        public int ID;
        public string Gender;
        public int Salary;
    }
    class Class2
    {
        static void Main(string[] args)
        {
            sample s1 = new sample();
            s1.a = 6;

            Console.WriteLine(s1.a);

            //<class-name> <object-name>=new <class-Name>()

            Employe E = new Employe();
            E.Name = "Prajwal";
            E.ID = 565654;
            E.Gender = "male";
            E.Salary = 20000;

            Console.WriteLine("Employe Details are");
            Console.WriteLine(E.Name);
            Console.WriteLine(E.ID);
            Console.WriteLine(E.Gender);
            Console.WriteLine(E.Salary);
        }
    }
}
