using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using UITestAutomation;
using UITestAutomationPageObjects.PageObjects.Account.AccountLogonClasses;

namespace ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValidateHomepage homePage = new ValidateHomepage();
            //Playback.Initialize();
            //homePage.BuyOneItemRockHandCoded();
            
            //Playback.Cleanup();
            
            //Playback.Initialize();
            //homePage.BuyOneItemRock();
            //Playback.Cleanup();

            //Playback.Initialize();
            //homePage.BuyOneItemRockHandCoded();
            //Playback.Cleanup();

            //Playback.Initialize();
            //homePage.BuyOneItemRock();
            //Playback.Cleanup();

            Playback.Initialize();
            BrowserWindow bw = BrowserWindow.Launch("http://localhost:26641/StoreManager/");

            AccountLogon logon = new AccountLogon(bw);
            logon.LoginWithSendKeys("UserName", "Password");
            Playback.Cleanup();


            Playback.Initialize();
             bw = BrowserWindow.Launch("http://localhost:26641/StoreManager/");

            logon = new AccountLogon(bw);
            logon.LoginWithSendKeys("UserName", "Password");
            Playback.Cleanup();


            Playback.Initialize();
            bw = BrowserWindow.Launch("http://localhost:26641/StoreManager/");

            logon = new AccountLogon(bw);
            logon.LoginWithSendKeys("UserName", "Password");
            Playback.Cleanup();

        
        
        }
    }
}
