using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMPTest
{
    class Login : Logout
    {
        public static IWebDriver Driver;
        public Login(IWebDriver driver)
            :base(driver)
        {
            Driver = driver;
        }
        public  Logout LoginCredentials(string username,string password)
        {
            Driver.FindElement(By.XPath(".//*[@id='login-email']")).SendKeys(username);
            Driver.FindElement(By.XPath(".//*[@id='login-password']")).SendKeys(password);
            return new Logout(Driver);
        }
    }
}
