using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                ID = 23,
                Name = "Ravi",
                Salary = 50000
            };

            Customer c2 = new Customer()
            {
                ID = 24,
                Name = "Teja",
                Salary = 40000
            };

            Dictionary<int, Customer> cust = new Dictionary<int, Customer>();
            cust.Add(c1.ID, c1);
            cust.Add(c2.ID, c2);
            //An item with same key will throw a run time exception
            //cust.Add(c2.ID, c2);
            if(cust.ContainsKey(245))
            {
                Customer cu = cust[245];
            }
            
            if(!cust.ContainsKey(c2.ID))
            {
                cust.Add(c2.ID, c2);
            }

            foreach(KeyValuePair<int,Customer> val in cust)
            {
                Customer cus = val.Value;
                Console.WriteLine("{0},{1},{2}",cus.ID,cus.Name,cus.Salary);
                
            }
            Console.ReadKey();


        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
