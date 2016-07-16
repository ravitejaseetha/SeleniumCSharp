using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci(5);
            var val = Fibonacci(5);
            foreach (var val1 in val)
            {
                Console.WriteLine(val1);

            }
            List<int> val2 = new List<int>();
            Console.ReadKey();
        }

        public static IEnumerable<int> Fibonacci(int x)
        {
            int prev = -1;
            int next = 1;
            for (int i = 0; i < x; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
                yield return sum;
            }

        }

        //public static void Fibonacci(int x)
        //{
        //    int prev = -1;
        //    int next = 1;
            
        //    for (int i = 0; i < x; i++)
        //    {
        //        int sum = prev + next;
        //        prev = next;
        //        next = sum;
        //        Console.WriteLine(sum);
                
        //    }

        //}
    }
}
