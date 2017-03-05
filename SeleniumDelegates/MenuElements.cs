using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDelegates
{
  
    class MenuElements
    {
        internal Utils Utils;

        public MenuElements(IWebDriver driver)
        {
            Utils = new Utils(driver);
        }

        public IWebElement Createnew
        {
            get { return Utils.Wait("lst-ib", By.Id, 4); }
        }

        public IWebElement Viewlist
        {
            get { return Utils.Find("Lists", By.LinkText); }
        }
    }
}
