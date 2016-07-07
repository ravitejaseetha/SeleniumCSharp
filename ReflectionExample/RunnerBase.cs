using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class RunnerBase 
    {

        public void ExecuteTest(IContext testContext)
        {
            
            
            testContext.Start();
            
            //testContext.Execute();
            //testContext.End();
        }
        public void ExecuteTest(List<string> names)
        {
            Type type;
            foreach(var name in names)
            {
                type = Type.GetType(string.Format("ReflectionExample.{0}", name));
                IContext test = (IContext)Activator.CreateInstance(type,Driver);
                ExecuteTest(test);
            }
        }

        public IWebDriver driver;
        public IWebDriver Driver
        {
            get
            {
                if(null == driver)
                {
                    driver = new FirefoxDriver();
                }
                return driver;
            }
        }
    }
}
