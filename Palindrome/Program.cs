using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string rev = "auu";
            Sample();
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            for(int i = s.Length-1;i>=0;i--)
            {
                rev = rev + s[i].ToString();
            }
            if(rev == s)
            {
                Console.WriteLine("Given string is a palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
            Console.ReadKey();
        }

        public static void Sample()
        {
            Console.WriteLine("sample");
        }
    }
}
