using System;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            using(AutosalonContext db = new AutosalonContext())
            {
                //db.Marks.Add(new Mark() { MarkName = "Toyota" });
                //db.SaveChanges();

                //db.Cars.Add(new Car() { MarkId = db.Marks.Select(o => o.Id).First(), Model = "Rav4", Engine = "Electro", Price = 20000 });
                //db.SaveChanges();
               Car c = db.Cars.Where(o => o.Id == 1).First();
                db.Cars.Remove(c);
                db.SaveChanges();
            }
        }
    }
}
