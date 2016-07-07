using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Cricinfo : IContext
    {

        public IWebDriver Driver;
        public Cricinfo(IWebDriver driver)
        {
            Driver = driver;
        }
        public void Start()
        {
            Driver.Navigate().GoToUrl("http://www.cricinfo.com");
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void End()
        {
            throw new NotImplementedException();
        }
    }
}
