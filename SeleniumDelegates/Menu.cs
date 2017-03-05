using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDelegates
{
    class Menu
    {
        internal Utils utils;
        internal MenuElements Elements;
        public Menu(IWebDriver driver)
        {
            utils = new Utils(driver);
            Elements = new MenuElements(driver);
        }

        public void CreateNewPatient()
        {
            utils.NavigateTo("http://www.google.com");
            Elements.Createnew.SendKeys("Hello");
        }
    }
}
