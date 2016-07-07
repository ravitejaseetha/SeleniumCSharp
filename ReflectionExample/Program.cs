using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RunnerBase runner = new RunnerBase();
            runner.ExecuteTest(GetDataConditionContexts());


        }

        public static List<string> GetDataConditionContexts()
        {
            return ConfigurationManager.AppSettings.AllKeys.ToList().Where(data => IsConditonData(data)).ToList();
        }
        public static bool IsConditonData(string key)
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings[key]);
        }
    }
}
