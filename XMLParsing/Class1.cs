using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XMLParsing
{
    public class Class1
    {
        //private IWebDriver driver;
        //public IWebDriver Driver
        //{
        //    get
        //    {
        //        if(null == driver)
        //        {
        //            driver = new ChromeDriver();

        //        }
        //        return driver;
        //    }
        //}

        private TestSettings test;
        protected TestSettings TestSetting
        {
            get
            {
                if(null == test)
                {
                    test = new TestSettings();
                }
                return test;
            }
        }
        [Test]
        public void SampleTest()
        {
            TestSetting.Driver.Navigate().GoToUrl(TestSetting.URL);
            
        }
    }
}
