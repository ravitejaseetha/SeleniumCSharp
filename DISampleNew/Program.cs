using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISampleNew
{
    public class Program : WebControl
    {
        static void Main(string[] args)
        {

            StreamWriter st = new StreamWriter(@"E:\message.txt");
            st.Write("adasdqweqwe");
            st.Close();
            //Click();
            StreamReader strem = new StreamReader(@"E:\message.txt");
            Console.WriteLine(strem.ReadToEnd());
            Console.ReadKey();
            strem.Dispose();
        }
    }
}
