using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Utility
    {
        internal static IControl GetControlFromWebElement(IWebElement webElement, ControlType aControlType)
        {
            if (aControlType == ControlType.Button)
            {
                return new SeleniumWebButton(webElement);
            }
            else
                return null;
        }
    }
}
