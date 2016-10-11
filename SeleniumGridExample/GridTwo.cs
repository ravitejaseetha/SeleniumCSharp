﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using ParallelExecution;
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
    public class GridTest2 : TestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;


        //[SetUp]
        //public void SetupTest()
        //{
        //    DesiredCapabilities capabilities = new DesiredCapabilities();

           
        //    capabilities = DesiredCapabilities.Chrome();
            
        //    capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
        //    capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
        //    capabilities.SetCapability(CapabilityType.Version, "35.0");
        //    //capabilities.SetCapability("version",35);
        //    driver = new RemoteWebDriver(new Uri("http://192.168.0.100:5555/wd/hub"), capabilities);
        //    //driver = new FirefoxDriver();
        //    baseURL = "https://www.google.co.in/";
        //    verificationErrors = new StringBuilder();
        //}

        [TearDown]
        public void TeardownTest()
        {
            Driver.Quit();
        }

        [Test, Description("Google Test Grid One test case 2")]
        [TestCaseSource(typeof(TestBase), "Browser")]
        public void GoogleTest1Grid(string browserName, string bro)
        {
            
            baseURL = "https://www.google.co.in/";
            SetCapabilities(browserName);
            
            Driver.Navigate().GoToUrl(baseURL + "/");
            Driver.FindElement(By.Id("lst-ib")).Clear();
            Driver.FindElement(By.Id("lst-ib")).SendKeys("Testing");
           // Driver.FindElement(By.Id("lst-ib")).Click();
            Thread.Sleep(10000);
        }
    }
}