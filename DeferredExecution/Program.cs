using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(2, "abc");
            dict.Add(3, "def");

            var result = dict.Where(x => x.Key > 2).Select(x => x.Key);
            dict.Add(4, "cccc");

            //Deferred Execution . dont compute the code until the caller actually uses it
            foreach(var val in result)
            {
                Console.WriteLine(val);
            }
            Console.ReadKey();
        }
    }
}
