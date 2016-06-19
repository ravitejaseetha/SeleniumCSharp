using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLParsing
{
    public enum BrowserType
    {
        IE,
        Firefox,
        GoogleChrome
    }

    public class TestSettings : BaseSettings
    {

        
        
        
        string url = "";
        string _Path;

         public TestSettings ()
	     {
             _Path = Path.Combine(Directory.GetCurrentDirectory(), "TestSettings.xml");
	     }
        public string URL
        {
            get
            {
                string value = GetValue(_Path, "AUMCPUrl");
                if(null != value)
                {
                    url = value;
                }
                return url;
            }
        }

        string browser = "Firefox";
        public string Browser
        {
            get
            {
                string value = GetValue(_Path,"Browser");
                if(null != value)
                {
                    browser = value;
                }
                return browser;
            }
        }


        public IWebDriver BrowserHandle;

        public IWebDriver Driver
        {
            get
            {
            if (Browser.Equals(BrowserType.Firefox.ToString()))
            {
                BrowserHandle = new FirefoxDriver();
                return BrowserHandle;
            }

            if (Browser.Equals(BrowserType.GoogleChrome.ToString()))
            {
                BrowserHandle = new ChromeDriver();
                return BrowserHandle;
            }
            return null;
            }
            
        }
        
    }
}
