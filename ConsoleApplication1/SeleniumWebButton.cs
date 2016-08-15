using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SeleniumWebButton : SeleniumWebControl,IButton
    {
        internal SeleniumWebButton(IWebElement webElement)
            :base(webElement)
        {

        }
    }
}
