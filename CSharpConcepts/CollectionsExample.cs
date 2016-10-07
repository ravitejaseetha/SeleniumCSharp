using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class CollectionsExample
    {
        public void SampleDictionary()
        {

            //Dictionary is collection of Key Value pairs
            Dictionary<int, string> dict = new Dictionary<int, string>() { {25,"add"},{26,"kkkk"}};
            dict.Add(23, "abc");
            dict[24] = "def";

            foreach (KeyValuePair<int, string> val in dict)
            {
                Console.WriteLine("{0},{1}", val.Key, val.Value);

            }

            dict.Remove(23);
            string value;
            var val1 = dict.TryGetValue(24,out value);
            foreach(KeyValuePair<int,string> vals in dict)
            {
                var val2 = dict.Contains(vals);
            }
            


            Dictionary<int, Employee> emp = new Dictionary<int, Employee>()
            {
                {1123, new Employee(){ EmpName = "Apple", Age=55 }},
                {2234, new Employee(){ EmpName = "Grapes", Age=65 }}
            };

            foreach (KeyValuePair<int, Employee> val in emp)
            {
                Console.WriteLine("{0},{1},{2}", val.Key, val.Value.EmpName,val.Value.Age);

            }
        }

        public void SampleList()
        {
            //List is collection of similar items

            List<string> lst = new List<string>() { "Sachin", "Ganguly" };
            lst.Add("Kohli");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
           
        }
    }

    class Employee
    {
        public string EmpName { get; set; }
        public int Age { get; set; }
    }
}
