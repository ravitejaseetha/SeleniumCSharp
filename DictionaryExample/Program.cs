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

            //Converting array to dictionary

            Customer[] customers = new Customer[3];
            customers[0] = c1;
            customers[1] = c2;
            

           Dictionary<int,Customer> dict =  customers.ToDictionary(custo => custo.ID, custo => custo);

            foreach(KeyValuePair<int,Customer> x in dict)
            {
                Customer c = x.Value;
                Console.WriteLine(c.ID + c.Name + c.Salary);
            } 

            //Converting list to Dictionary
            List<Customer> custDiction = new List<Customer>();
            custDiction.Add(c1);
            custDiction.Add(c2);

            Dictionary<int, Customer> xy = custDiction.ToDictionary(cu => cu.ID, cu => cu);
 
            Dictionary<int, Customer> cust = new Dictionary<int, Customer>();
            cust.Add(c1.ID, c1);
            cust.Add(c2.ID, c2);

            //An item with same key will throw a run time exception
            //cust.Add(c2.ID, c2);


            //Count
            //The value inside the count is predicate
            Console.WriteLine("Total Count" + cust.Count(kvp => kvp.Value.Salary > 40000));

           // cust.Remove(23);
          //  cust.Clear();

            if(cust.ContainsKey(245))
            {
                Customer cu = cust[245];
            }

            if (!cust.ContainsKey(c2.ID))
            {
                cust.Add(c2.ID, c2);
            }

            //Try Get Value
            Customer cust1;
            if(cust.TryGetValue(230,out cust1))
            {
                Console.WriteLine("{0},{1},{2}", cust1.ID, cust1.Name, cust1.Salary);
            }
            else
            {
                Console.WriteLine("Key not found");
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
