
using System;
using ConsoleApp5.Models;
using System.Linq;
namespace ConsoleApp5
{
    class Program
    {
        static void Main1(string[] args)
        {
            SampleDb1Context db = new SampleDb1Context();
            /*Sample1 tblsample = new Sample1();
            tblsample.Text = "Prajwal Pophali";
             db.Sample1s.Add(tblsample);
              db.SaveChanges();
             Console.WriteLine();*/


            var data = db.Sample1s;

            Console.WriteLine("Values from database ");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
           /* Console.WriteLine("Pleae enter id of your name which you want to delete");
            int DeleteItem = Convert.ToInt32(Console.ReadLine());
            var DeleteObject = db.Sample1s.Where(x => x.Id == DeleteItem).FirstOrDefault();
            db.Sample1s.Remove(DeleteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }*/

            Console.WriteLine("Pleae enter id of your name which you want to update");
            int InsertItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new name");
            var newName = Console.ReadLine();
            var UpdatteObject = db.Sample1s.Where(x => x.Id == InsertItem).FirstOrDefault();
            UpdatteObject.Text = newName;
            db.Sample1s.Update(UpdatteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
        }
    }
}
