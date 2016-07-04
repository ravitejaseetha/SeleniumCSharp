using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass By value
            int j = 10;
            Sample(j);
            Console.WriteLine(j);


            //Pass by referrence 
            //Variables must me initialized in pass by referrence unlike in out parameters it is not necessary
            int k = 11;
            Sample1(ref k);
            Console.WriteLine(k);
            

           //Out parameters
           int add ;
           int mul ;
            Sample2(4, 6, out add,out mul);
            Console.WriteLine(add + "" + mul);


            //Params
            var value = Sample3(4, 5, 6, 7);
            Console.WriteLine(value);
            Console.ReadKey();
        }

        public static void Sample(int i)
        {
            i = 6;
        }

        public static void Sample1(ref int i)
        {
            i = 5;
        }

        public static void Sample2(int a,int b,out int add,out int  mul)
        {
            add = a + b;
            mul = a * b;
        }

        public static int Sample3(params int[] val)
        {
            int sal =0;
            foreach(var value in val)
            {
                sal += value;
            }
            return sal;
        }

    }
}
