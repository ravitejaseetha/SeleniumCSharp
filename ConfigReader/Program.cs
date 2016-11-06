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
            Console.WriteLine(value);
            Console.ReadKey();
            SendKeys.SendWait("{Enter}");

        }
    }
}
