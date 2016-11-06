using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 17463.ToString().ToCharArray().Sum(s => s - '0');

            var ll = 17463.ToString().Sum(c => Convert.ToInt32(c));
            var l = i.ToString().ToCharArray().Reverse();
            var l1 = i.ToString().Reverse();
            foreach (var item in l1)
            {
                Console.Write(item);
            }

            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);

            int n = 1234;
            int sum = 0;
            while (n != 0) {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
            string text = "helleh";
            
           // string text1 = "hello";
            var result = Enumerable
                .SequenceEqual(text.ToCharArray(), text.ToCharArray()
                .Reverse());
            Console.ReadLine();
        }
    }
}
