using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberStringRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = null;
            //string s = o.ToString();
            var convertValue = Convert.ToString(o);
            int val = 4231;
            int reverse = 0;
            while (val > 0)
            {
                reverse = (reverse * 10) + val % 10;
                val = val / 10;
            }
            Console.WriteLine(reverse);


            //Reverse a string
            string value = Console.ReadLine();
            string[] arrValue = value.Split(' ');

            for (int i = arrValue.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrValue[i]);
            }
                
            //Random number generator
                int x =8;
                string randomValue = "abcdefghijklmnopqrstuvwxyz123456789";
                Random random = new Random();
                StringBuilder sb = new StringBuilder();
                while(0<x--)
                {
                    sb.Append(randomValue[random.Next(randomValue.Length)]);
                }
                Console.WriteLine(sb);
                Console.WriteLine(random.Next(98));

                Console.ReadKey();

        }
    }
}
