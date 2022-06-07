
using System;
using ConsoleApp5.Models;
using System.Linq;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();
            // Sample1 tblsample = new Sample1();
            //tblsample.Text = "Prajwal Pophali";
            // db.Sample1s.Add(tblsample);
            //  db.SaveChanges();
            // Console.WriteLine();*/


            var data = db.Sample1s;

            Console.WriteLine("Values from database ");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
        }
    }
}
