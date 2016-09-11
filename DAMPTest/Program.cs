using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMPTest
{
    class Program 
    {
        public static IWebDriver Driver;
     
        static void Main(string[] args)
        {

            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http:\\www.linkedin.com");
            Driver.Manage().Window.Maximize();
            Login log = new Login(Driver);
            log.LoginCredentials("ravi", "teja").LogoutApp();
        }
    }
}
