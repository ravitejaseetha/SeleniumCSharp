using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelExecution
{
    [TestFixture]
    [Parallelizable]
    public class Class1 : TestBase
    {
  
        [Test]
        [TestCaseSource( typeof(TestBase), "Browser")]
        public void Login(string browserName)
        {
            Setup(browserName);
            
            Thread.Sleep(30000);
        }
    }
}
