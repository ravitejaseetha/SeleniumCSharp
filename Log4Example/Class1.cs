using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using log4net;

namespace Log4Example
{
    public class LogClass
    {
        private static log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [Test]
        public void SampleLog()
        {
            Logger.Fatal("Inside Logger");
            var val = Logger.GetType().ToString();
            Console.WriteLine(val);
        }
    }
}
