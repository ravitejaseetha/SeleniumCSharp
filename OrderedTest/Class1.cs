using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedTestExample
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Class1
    {
        //[Test]
        //[Order(0)]
        //public void ExampleOne()
        //{
        //    Console.WriteLine("Example1");
        //}
        [Test]
        //[Order(0)]
       // [Parallelizable(ParallelScope.Children)]
        public void ExampleTwo()
        {
            IWebDriver driver1 = new ChromeDriver();
            driver1.Navigate().GoToUrl("http://www.yahoo.com");
            driver1.Manage().Window.Maximize();
        }
        [Test]
        //[Parallelizable(ParallelScope.Children)]
        public void ExampleB()
        {
            IWebDriver driver2 = new ChromeDriver();
            driver2.Navigate().GoToUrl("http://www.google.com");
            driver2.Manage().Window.Maximize();
        }

    }
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Sample
    {
        [Test]
        // [Order(1)]
      //  [Parallelizable]
        public void ExampleA()
        {
            IWebDriver driver2 = new ChromeDriver();
            driver2.Navigate().GoToUrl("http://www.google.com");
            driver2.Manage().Window.Maximize();
        }
    }
}
