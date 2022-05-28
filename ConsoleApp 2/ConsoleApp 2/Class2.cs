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

        public void GetData()
        {
            Console.WriteLine("Please Enter the Employe Details");
            Console.WriteLine("please Enter the Employe Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter the Employe ID");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Employe Gender");
            Gender = Console.ReadLine();
            Console.WriteLine("Please Enter the Employe Salary");
            Salary = Convert.ToInt32(Console.ReadLine());

        }
        public void PrintData()
        {
            Console.WriteLine("Employe Details are");
            Console.WriteLine("Name");
            Console.WriteLine("Id");
            Console.WriteLine("Gender");
            Console.WriteLine("Salary");
        }
    }
        
    class Class2
    {
        static void Main(string[] args)
        {
            /*  sample s1 = new sample();
              s1.a = 6; 

              Console.WriteLine(s1.a);



              Employe E = new Employe();
              E.Name = "Prajwal";
              E.ID = 565654;
              E.Gender = "male";
              E.Salary = 20000;

              Console.WriteLine("Employe Details are");
              Console.WriteLine(E.Name);
              Console.WriteLine(E.ID);
              Console.WriteLine(E.Gender);
              Console.WriteLine(E.Salary);*/
            
            
            Employe[] Employelist = new Employe[2];
            for (int i = 0; i < Employelist.Length; i++)
            {
                Employe E = new Employe();
                E.GetData();
                Employelist[i] = E;
            }

            for (int i = 0; i < Employelist.Length; i++)
            {
                Employelist[i].PrintData();
            }
        }
    }
}
