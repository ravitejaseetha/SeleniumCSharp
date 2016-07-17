using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> myAction = new Action<int>(DoSomething);
            myAction(123);           // Prints out "123"
            // can be also called as myAction.Invoke(123);

            Func<int, double> myFunc = new Func<int, double>(CalculateSomething);
            Console.WriteLine(myFunc(5));   // Prints out "2.5"


            Predicate<string> isUpper = IsUpperCase;
            Predicate<string> pre = new Predicate<string>(IsUpperCase);
            bool result = isUpper("HELLO WORLD!!");
            bool result1 = pre("hello");
            Console.WriteLine(result +" "+ result1);


            Console.ReadKey();
        }

        static void DoSomething(int i)
        {
            Console.WriteLine(i);
        }

        static double CalculateSomething(int i)
        {
            return (double)i / 2;
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
