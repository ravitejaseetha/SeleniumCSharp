using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelExecution
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(InternetExplorerDriver))]
    [TestFixture(typeof(ChromeDriver))]
    [Parallelizable(ParallelScope.Fixtures)]
    public class TestWithMultipleBrowsers<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver;

        [SetUp]
        public void CreateDriver()
        {
            this.driver = new TWebDriver();
        }

        [Test]
        [Category("ParallelBrowsers")]
        public void GoogleTestMultiple()
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            IWebElement query = driver.FindElement(By.Id("lst-ib"));
            query.SendKeys("Bread" + Keys.Enter);

            Thread.Sleep(2000);

            Assert.AreEqual("bread - Google Search", driver.Title);
            driver.Quit();
        }
    }
}
