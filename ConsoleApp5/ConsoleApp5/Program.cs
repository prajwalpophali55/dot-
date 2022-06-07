
using System;
using ConsoleApp5.Models;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();
            Sample1 tblsample = new Sample1();
            tblsample.Text = "Prajwal Pophali";
            db.Sample1s.Add(tblsample);
            db.SaveChanges();
            Console.WriteLine();
        }
    }
}
