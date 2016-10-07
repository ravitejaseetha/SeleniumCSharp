using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;
using Nessos.LinqOptimizer.CSharp;


namespace CSharpConcepts
{
    class LinqExamples
    {
        List<EmployeeDetails> emp;
        public void SampleLinq()
        {
            emp = new List<EmployeeDetails>()
            {
                new EmployeeDetails(){ Name = "Ravi", ID = 519195, Company ="EPAM" },
                new EmployeeDetails(){ Name = "Teja", ID = 519165, Company ="AGs" },
                new EmployeeDetails{ Name = "Sachin", ID = 519195, Company ="EPAM" },
            };

            //Linq with lambda expressions
            var emp1 = emp.Where((c) => c.Company == "AGs").OrderBy(x => x.Name).Select(x => new { x.Name, x.ID });

            //Deffered execution-------Dont compute the code until the caller actually uses it
            emp.Add(new EmployeeDetails() { Name = "John", ID = 3434, Company = "AGs" });

            foreach (var val in emp1)
            {
                Console.WriteLine(val.Name + " " + val.ID);
            }

            string[] input = { "Ravi", "Sureshdddddddddddddddd", "Sreenivas", "BhanuPrasad" };
            //To get maximum length string name and string count
            var output = input.OrderByDescending(x => x.Count()).Select(x => new
            {
                StringName = x,
                StringLenght = x.Count()
            }).FirstOrDefault();
            Console.WriteLine(output.StringName + "And its length " + output.StringLenght);
            
            //Add Morelinq nuget for MaxBy
            var val1 = input.MaxBy(x => x.Length);
            Console.WriteLine("Name{0}and length{1}", val1, val1.Count());

            var rr = Enumerable.Range(1, 20).Batch(2).Select(x => x);
            foreach (var item in rr)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
               
            }


            var strings = new List<string>() { "Hello", "Bye" };
            //Lazy evaluation.It wont print the values unless it is looped outside this line.Select returns lazly
            var upperCase = strings.Select(X => { Console.WriteLine(X); return (X); });
                                    
            //evaluated IEnumerable sequence
            foreach (var item in upperCase)
            {
                Console.WriteLine(item.ToUpper());
            }

           // strings.Select(x => x.ToUpper()).ForEach(x => Console.WriteLine(x));//it will print

            //Linq using query
            var vals = from i in strings
                       where i.Length > 3
                       select i;

            foreach (var item in vals)
            {
                Console.WriteLine(item);
            }

            foreach (var item in strings)
            {
                var dd = item.Skip(1);
            }

        }
            public IEnumerable<EmployeeDetails> SortByCompany()
            {
                return emp.OrderBy(c => c.Company).ThenBy(c => c.Name);
            }



            public IEnumerable<EmployeeDetails> SortByNameInReverse()
            {
                return emp.OrderByDescending(c => c.Name).Reverse();
            }

            string str = "This is Ravi";

            public void ReverseString()
            {
                var st = str.Split(' ').Reverse();
                foreach (var item in st)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            public void CompareSequnces()
            {
                var seq1 = Enumerable.Range(0, 10);
                var seq2 = Enumerable.Range(0, 10)
                                      .Select(i => i * i);
                var df = seq1.Intersect(seq2);
                Console.WriteLine("Intersect");
                foreach (var item in df)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Except");
                var cd = seq1.Except(seq2);
                foreach (var item in cd)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Concat");
                var cd1 = seq1.Concat(seq2);//With duplicates   
                foreach (var item in cd1)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Union");
                var cd2 = seq1.Union(seq2);//Without duplicates(i., distinct)
                foreach (var item in cd2)
                {
                    Console.WriteLine(item);
                }

                var query = emp.Select(x => new
                    {
                        FirstName = x.Name,
                        CompanyName = x.Company,
                    }).OrderBy(x => x.FirstName);
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.CompanyName);
                }
            }

        }
    

    class EmployeeDetails
    {
        
        public string Name { get; set; }
        public int ID { get; set; }
        public string Company { get; set; }
    }
}
