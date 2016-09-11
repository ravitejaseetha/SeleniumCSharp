using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"[A-z]");
            string text = "1a2222c333";
            string[] splitWords = pattern.Split(text);
            foreach (var item in splitWords)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
