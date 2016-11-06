using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int i = int.Parse(Console.ReadLine());
            //int fact = GetNumber(i);
            int fact1 = GetFactorial(i);
            Console.WriteLine(fact1);
            IEnumerable<int> ints = Enumerable.Range(1, 5);
            int factorial = ints.Aggregate((f, s) => f * s);
            Console.ReadKey();
        }

        public void Sa()
        {
            Console.Write("ad");
        }

        protected static int GetNumber(int i)
        {
            if(i == 0)
            {
                return 1;
            }

            return i * GetNumber(i - 1);
        }

        public static int GetFactorial(int number)
        {
            int value = 1;
            if(number == 0)
            {
                return 1;
            }

            else
            {
                for(int i = number;i>=1;i--)
                {
                    value = value * i;
                }
               // return value;
            }
            return value;
        }
    }
}
