using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoIt;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace AutoItExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //AutoITExtension Auto = new AutoITExtension();
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.linkedin.com");
            //driver.Manage().Window.Maximize();
            //Runtime run = Runtime.getRuntime();
            //Process pp = run.exec("C:\\PathToFile\\AILoginScript.exe");

            AutoItX.Run("Skype.exe","C:\\Program Files (x86)\\Skype",1);
            Thread.Sleep(10000);
            AutoItX.Send("seetha841");
            Thread.Sleep(2000);
            AutoItX.Send("{TAB}");
            Thread.Sleep(2000);
            AutoItX.Send("{ENTER}");
            //AutoItX.s
            Thread.Sleep(5000);
        }
    }
}
