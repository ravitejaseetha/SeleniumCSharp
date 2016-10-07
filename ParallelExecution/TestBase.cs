using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelExecution
{
    public class TestBase
    {
        protected IWebDriver driver;
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
            foreach (var item in browsers)
            {
                yield return item;
            }
        }
    }
}
