using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new List<Emplyoee>()
            {
                new Emplyoee(){ Name = "Ravi", ID = 519195, Company ="EPAM" },
                new Emplyoee(){ Name = "Teja", ID = 519165, Company ="AGs" },
                new Emplyoee{ Name = "Sachin", ID = 519195, Company ="EPAM" },
            };

            var emp1 = emp.Where((c) => c.Company == "AGs") .OrderBy(x => x.Name).Select(x => new { x.Name, x.ID });

            //Deffered execution-------Dont compute the code until the caller actually uses it
            emp.Add(new Emplyoee() { Name = "John", ID = 3434, Company = "AGs" });

            foreach(var val in emp1)
            {
                Console.WriteLine(val.Name +" "+val.ID);
            }
            Console.ReadKey();
        }
    }

    class Emplyoee
    {
        public string Name { get; set; }

        public int ID { get; set; }
        public string Company { get; set; }
    }
}
