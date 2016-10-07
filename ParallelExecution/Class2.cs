using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    class Class2 : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "Browser")]
        public void LogNew(string browserName)
        {
            Setup(browserName);
           
            Thread.Sleep(10000);
        }
    }
}
