using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = ConfigurationManager.AppSettings["Username"];
            string name = "Ravi teja";
            var result = name.Split(' ').OrderByDescending(x => x);
            Console.WriteLine(value);
            Console.ReadKey();
            SendKeys.SendWait("{Enter}");
           var v =  Method("Hello world");

        }

        public static string Method(string input)
        {
            var val = input.Split(' ');
            string output = null;
            for (int i = val.Count(); i > 0; i--)
            {
                output  = output + val[i-1] + " ";
            }

            return output;
        }
    }
}
