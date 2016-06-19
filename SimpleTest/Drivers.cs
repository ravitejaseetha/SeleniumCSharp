using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    public enum BrowserType
    {
        Firefox,

        IE,

        Chrome,
    }
    public class Drivers
    {
        public string BinaryPath { get; set; }
        public Drivers(BrowserType browserType, string binaryPath)
        {
            BinaryPath = binaryPath;
            GetBrowser(browserType);

        }
        internal BrowserType BrowserType;
        internal IWebDriver BrowserHandle;
        public void GetBrowser(BrowserType browserType)
        {
            BrowserType = browserType;
            if(browserType == BrowserType.Firefox)
            {
                BrowserHandle = FirefoxDriver;
            }
            if(browserType == BrowserType.Chrome)
            {
                BrowserHandle = ChromeDriver;
            }
            if(browserType == BrowserType.IE)
            {
                BrowserHandle = IEDriver;
            }
        }
        private IWebDriver FirefoxDriver
        {
            get
            {
                return new FirefoxDriver();
            }
        }

        private IWebDriver IEDriver
        {
            get
            {
                return new InternetExplorerDriver(Config.DriverServerPath);
            }
        }

        private IWebDriver ChromeDriver
        {
            get
            {
                return new ChromeDriver(Config.DriverServerPath);
            }
        }
    }
}
