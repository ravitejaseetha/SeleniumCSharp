using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMPTest
{
    class Logout
    {
        public IWebDriver Driver;
        public Logout(IWebDriver driver)
        {
            Driver = driver;
        }
        public  Logout LogoutApp()
        {
            Driver.FindElement(By.XPath(".//input[@type='submit']")).Click();
            return this;
        }
    }
}
