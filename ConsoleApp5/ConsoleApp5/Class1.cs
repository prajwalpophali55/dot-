using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp5
{
    class Class1
    {
        static void Main(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();
            while (true)
            {
                Console.WriteLine("Please enter some choice \n 1.Add Record \n 2.List Record \n 3.Update Record \n 4.Delete Record \n 5.Exit");
                Console.WriteLine("=============================================");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your name");
                        string name = Console.ReadLine();

                        Sample1 tblsample = new Sample1();
                        tblsample.Text = "Prajwal Pophali";
                        db.Sample1s.Add(tblsample);
                        db.SaveChanges();
                        Console.WriteLine();
                        break;

                }
            }

           
        }

           
    }
}
