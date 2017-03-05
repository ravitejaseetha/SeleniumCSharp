using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJSON
{
    class Program
    {
        internal static IDataProvider<Patient> DataProvider;
        static void Main(string[] args)
        {
            Data();
        }

        public static void Data()
        {
            DataProvider = new JsonDataProvider<Patient>();
            var patient = DataProvider.GetFirstRecord();
        }
       
    }
}
