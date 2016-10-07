using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumGridExample
{
    [Parallelizable]
    [TestFixture]
    public class GridTest2
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;


        [SetUp]
        public void SetupTest()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();

           
            capabilities = DesiredCapabilities.Chrome();
            
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            capabilities.SetCapability(CapabilityType.Version, "35.0");
            //capabilities.SetCapability("version",35);
            driver = new RemoteWebDriver(new Uri("http://192.168.0.100:5555/wd/hub"), capabilities);
            //driver = new FirefoxDriver();
            baseURL = "https://www.google.co.in/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void GoogleTest1()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("gbqfq")).Clear();
            driver.FindElement(By.Id("gbqfq")).SendKeys("Testing");
            driver.FindElement(By.Id("gbqfb")).Click();
            Thread.Sleep(10000);
        }
    }
}