using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
//using //System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseConnExample
{
    class DatabaseConn 
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new FirefoxDriver();
           // DesiredCapabilities cap =  DesiredCapabilities.InternetExplorer();

           ////IWebDriver driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), DesiredCapabilities.Android());
           //cap.SetCapability(CapabilityType.AcceptSslCertificates, true);
           // IWebDriver driver = new InternetExplorerDriver();
           // driver.Manage().Window.Maximize();
           // driver.Navigate().GoToUrl("https://cacert.org/");
           // Actions act = new Actions(driver);
           // act.KeyDown(Keys.Shift);
           // act.KeyUp(Keys.Control);



            StreamWriter sw1 = new StreamWriter(@"E:\message.txt");
            sw1.WriteLine("Total Touirsts");
            sw1.Close();


           // driver.Navigate().GoToUrl(baseURL);
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection("Data Source=RAVIPC\\SQLEXPRESS;" + "Initial Catalog=PTS; Trusted_Connection=Yes"); //Windows Authentication
            string sql = @"select firstname from tourists";
            comm.CommandText = sql;
            comm.Connection.Open();
            SqlDataReader cursor = comm.ExecuteReader();
            while (cursor.Read())
            {
                string username = cursor["firstname"].ToString();
               // string password = cursor["Password"].ToString();
              //  driver.Navigate().GoToUrl("http://www.google.com");
               // driver.FindElement(By.LinkText("REGISTER")).Click();
                //driver.FindElement(By.Name("email")).SendKeys(username);
               // driver.FindElement(By.Name("password")).SendKeys(password);
               // driver.FindElement(By.Name("confirmPassword")).SendKeys(password);
                StreamWriter sw = new StreamWriter(@"E:\message.txt",true);
                sw.WriteLine(username);
                
                sw.Close();
            }
            
            comm.Connection.Close();

            SqlCommand comm1 = new SqlCommand();
            comm1.Connection = new SqlConnection("Data Source=RAVIPC\\SQLEXPRESS;" + "Initial Catalog=PTS; Trusted_Connection=Yes"); //Windows Authentication
            string sql1 = @"select firstname from tourists";
            comm1.CommandText = sql1;
            comm1.Connection.Open();
            SqlDataReader cursor1 = comm1.ExecuteReader();
            while (cursor1.Read())
            {
                string username = cursor1["firstname"].ToString();
               // string password = cursor["Password"].ToString();
              //  driver.Navigate().GoToUrl("http://www.google.com");
               // driver.FindElement(By.LinkText("REGISTER")).Click();
                //driver.FindElement(By.Name("email")).SendKeys(username);
               // driver.FindElement(By.Name("password")).SendKeys(password);
               // driver.FindElement(By.Name("confirmPassword")).SendKeys(password);
                StreamWriter sw = new StreamWriter(@"E:\message.txt",true);
                sw.WriteLine(username);
                
                sw.Close();
            }
            comm1.Connection.Close();
        }
    }
}
