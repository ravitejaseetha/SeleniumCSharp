using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDelegates
{
    class Utils
    {
        internal IWebDriver Driver { get; private set; }
        public Utils(IWebDriver driver)
        {
            Driver = driver;
        }


        public IWebElement Find(string id, Func<string, By> parser)
        //this function is called to search for web elements using By. attribute provided by Selenium web driver
        {
            return Executer(parser(id), Driver.FindElement); // : SafeExecute(parser(id), Driver.FindElement);
        }

        private TReturn Executer<TValue, TReturn>(TValue value, Func<TValue, TReturn> func)
        // trying to execute finding an element in a webpage
        {
            return func(value);
        }


        public IWebElement Wait(string id, Func<string, By> parser, int waitTime)
        {

            //var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime));
            //wait.Until(ExpectedConditions.ElementIsVisible(parser(id)));
            return Find(id, parser);
        }


        public Utils NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }
    }
}
