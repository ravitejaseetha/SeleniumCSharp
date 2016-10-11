using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelExecution
{
    public class TestBase
    {
        public IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }
        public void Setup(string browserName)
        {
            if (browserName.Equals("firefox"))
                driver = new ChromeDriver();
            else if(browserName.Equals("chrome"))
                driver = new ChromeDriver();


            driver.Manage().Window.Maximize();
        }

        public static IEnumerable<string> Browser()
        {
            // string[] browsers = { "chrome", "firefox" };
            string[] browsers = Resource1.Browser.Split(',');
            string[] ipAddress = Resource1.RemoteWeb.Split(',');
            foreach (var item in browsers)
            {
                yield return item;
            }
        }

       




        public static IEnumerable<string> IpAddress()
        {
            // string[] browsers = { "chrome", "firefox" };
            string[] urls = Resource1.RemoteWeb.Split(',');
            foreach (var item in urls)
            {
                yield return item;
            }
        }

        public void SetCapabilities(string browsername)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();

            //if (browsername.Equals("chrome"))
            //{
            //    capabilities = DesiredCapabilities.Chrome();
            //    capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            //}
                
         //   else if (browsername.Equals("firefox"))
         //   {
                //capabilities = DesiredCapabilities.Firefox();
                //capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
          //  }
                
            

            
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            capabilities.SetCapability(CapabilityType.Version, "35.0");
            //capabilities.SetCapability("version",35);
            if(browsername.Equals("firefox"))
            {
                capabilities = DesiredCapabilities.Firefox();
                capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
                driver = new RemoteWebDriver(new Uri("http://192.168.0.100:5557/wd/hub"), capabilities);
            }
            else if(browsername.Equals("chrome"))
            {
                capabilities = DesiredCapabilities.Chrome();
                capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
                driver = new RemoteWebDriver(new Uri("http://192.168.0.100:5555/wd/hub"), capabilities);
            }
           
            //driver = new FirefoxDriver();
            baseURL = "https://www.google.co.in/";
            verificationErrors = new StringBuilder();
        }
    }
}
