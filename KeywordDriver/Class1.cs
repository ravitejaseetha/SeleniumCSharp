using NUnit.Framework;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace KeywordDriven
{
    public class Class1
    {
        [Test]
        public void KeyWordDriven()
        {
            IWebDriver driver = new FirefoxDriver();
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "e:\\KeywordDriven.xlsx" + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
            string selectScenario = "SELECT * from [Driver$] ";
            OleDbConnection con1 = new OleDbConnection(connectionstring);
            OleDbCommand cmd1 = new OleDbCommand(selectScenario, con1);
            con1.Open();
            OleDbDataReader thedata1 = cmd1.ExecuteReader();
            Dictionary<string,string> Scenariolst = new Dictionary<string,string>();
            while (thedata1.Read())
            {
                Scenariolst.Add(thedata1[0].ToString(), thedata1[1].ToString());
               

            }

            foreach (var item in Scenariolst)
            {
                driver.Navigate().GoToUrl(item.Value);
                string selectusername = "SELECT * from ["+ item.Key +"$] ";
                OleDbConnection con = new OleDbConnection(connectionstring);
                OleDbCommand cmd = new OleDbCommand(selectusername, con);
                con.Open();
                OleDbDataReader thedata = cmd.ExecuteReader();
                while (thedata.Read())
                {
                    // var rt = thedata.GetValue(1).ToString();
                    string control = thedata[0].ToString();
                    string action = thedata[1].ToString();
                    string valu = thedata[2].ToString();
                   // ProcessTest(driver, control, action, valu);

                }
                
            }
          
        }

        private void ProcessTest(IWebDriver driver, string control,string action,string valu)
        {
            var controlEle = GetControl(driver,control);
            ExecuteAction(controlEle,action,valu);
        }

        private void ExecuteAction(IWebElement element,string action,string valu)
        {
           if(action == "Edit")
           {
               element.SendKeys(valu);
           }
           if(action == "Click")
           {
               element.Click();
           }
        }

        private IWebElement GetControl(IWebDriver driver, string control)
        {
            IWebElement element = driver.FindElement(By.XPath(control));
            return element;
        }
    }
}
