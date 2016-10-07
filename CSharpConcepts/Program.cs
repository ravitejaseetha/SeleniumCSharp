using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegates dl = new Delegates();
            //dl.AccessDelegate();

            //SampleInheritance s1 = new SampleInheritance();
            //s1.DerivedExample();
            //s1.BaseMethod();

            //Polymorphism p1 = new DerivedPolymorphism();
            //p1.SampleOverride(2);
            //p1.SampleHiding(3);

            //Encapsulation e1 = new Encapsulation();
            //e1.Balance = 100;

            //ConstructorExample c1 = new ConstructorExample("Hello");

            //ExceptionHandling ex1 = new ExceptionHandling();
            //ex1.ExceptionSample();

            //CollectionsExample col = new CollectionsExample();
            //col.SampleDictionary();
            //col.SampleList();

            //StringOperations sop = new StringOperations();
            //sop.Operations();

            LinqExamples linq = new LinqExamples();
            linq.SampleLinq();
            var d = linq.SortByCompany();
            foreach (var item in d)
            {
                Console.WriteLine(item.Company +" - " + item.Name);
            }
            var dc = linq.SortByNameInReverse();
            foreach (var item in dc)
            {
                Console.WriteLine(item.Name);
            }

             linq.ReverseString();
             linq.CompareSequnces();
            Console.ReadKey();
        }
    }
}
