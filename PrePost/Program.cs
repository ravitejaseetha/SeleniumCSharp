using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrePost
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a++;//Assign and increment output will be a=2,b=1
            int c = ++a;
            Console.WriteLine(a + " " + b);

            int x = 2;
            int y = ++x;//Increment and assign x=3,y=3
            Console.WriteLine(x + " " + y);
            Console.ReadKey();
        }
    }
}
