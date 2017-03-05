using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDelegates
{
    public class TestScript
    {
        private readonly IWebDriver driver;
        public TestScript()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void DelegateExample()
        {
            var menu = new Menu(driver);
            menu.CreateNewPatient();

        }
    }
}
