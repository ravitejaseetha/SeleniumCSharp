using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OledbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "ad";
           
            
           //IWebDriver driver = new FirefoxDriver();
           //driver.Navigate().GoToUrl("http://www.flipkart.com/");
           //string text = driver.PageSource;
           //if (text.Contains("puxlXr"))
           // {
           //     Console.WriteLine("hello world");
           // }
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "e:\\Sample.xls" + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
            string selectusername = "SELECT Username from [Test$] ";
            OleDbConnection con = new OleDbConnection(connectionstring);
            OleDbCommand cmd = new OleDbCommand(selectusername, con);
            con.Open();
            OleDbDataReader thedata = cmd.ExecuteReader();
            
            while (thedata.Read())
            {
                var rt = thedata.GetValue(1).ToString();
                string username = thedata[0].ToString();
                //string password = thedata[1].ToString();
                StreamWriter sw1 = new StreamWriter(@"E:\message.txt");
                sw1.WriteLine(username);
                sw1.Close();
                //driver.Navigate().GoToUrl("http://www.google.com");
                //driver.FindElement(By.LinkText("REGISTER")).Click();
                //driver.FindElement(By.Name("email")).SendKeys(username);
                //driver.FindElement(By.Name("password")).SendKeys(password);
                //driver.FindElement(By.Name("confirmPassword")).SendKeys(password);
            }

        }
    }
}
