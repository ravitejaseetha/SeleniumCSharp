using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void NumberChanger(int n);
namespace AnonymousMethod
{
    class Program
    {
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances using anonymous method
            //NumberChanger nc = delegate(int x)
            //{
            //    Console.WriteLine("Anonymous Method: {0}", x);
            //};

            //Delegate using lambda expression

            NumberChanger nc = x => Console.WriteLine("Lambda expression :{0}",x);

            Func<int, int> f1 = delegate(int i) { return i + 1; };
            Func<int, int> f2 = i => i * 2;

            Console.WriteLine("Func delegate with anonymous method " + f1(10));

            Console.WriteLine("Func delegate with lambda expression " + f2(10));

            //calling the delegate using the anonymous method 
            nc(10);

            //instantiating the delegate using the named methods 
            nc = new NumberChanger(AddNum);

            //calling the delegate using the named methods 
            nc(5);

            //instantiating the delegate using another named methods 
            nc = new NumberChanger(MultNum);

            //calling the delegate using the named methods 
            nc(2);
            Console.ReadKey();
        }
    }
}
