using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System.Diagnostics;


namespace CodedUIMultiTabBrowser
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void TestMultiTabBrowser()
        {
            var browserWindow = BrowserWindow.Launch("http://localhost:7032/");
            
            // get the tab strip in IE
            // since its the only tab when we start, we don't provide additional search properties
            WinTabList tablist = new WinTabList(browserWindow);
            WinTabPage tabPage = new WinTabPage(tablist);

            // Search for the hyperlink button to open up a new tab
            HtmlHyperlink link = new HtmlHyperlink(browserWindow.CurrentDocumentWindow);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id , "newTabHyperlink");
            
            // start a new tab by clicking the button
            Mouse.Click(link);
            
            // re-activate the home page tab
            Mouse.Click(tabPage);

            // click again, to get the second tab
            Mouse.Click(link);
            
            //// and again....
            Mouse.Click(tabPage);
            
            // click again, to get the second tab
            Mouse.Click(link);
            
            // Now locate a tab based on the window title after we set the tab focus again 
            // to the main page and see which tab it select. you will see when you uncomment
            // the next line that the call to locate will fail. this is caused because the active tab
            // in the browser is now the home page and not the new tab we look for
            // Mouse.Click(tabPage);
        
            // this will search cross all open browser windows and looks for
            // any tab that has this title and is the active tab. 
            // if no active tab is found this function will fail
            var browsertab = BrowserWindow.Locate("New Tab");

            HtmlDiv itemtofindOnNewTab = new HtmlDiv(browsertab);
            itemtofindOnNewTab.SearchProperties.Add(HtmlDiv.PropertyNames.Id, "itemToFind");
            Console.WriteLine(itemtofindOnNewTab.InnerText);
             
        }

       

        [TestMethod]
        public void CloseTabUsingBrowserWindowControl()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            var browserWIndow = BrowserWindow.Launch("http://localhost:7032/");

            // find the hyperlink to start a new tab
            HtmlHyperlink link = new HtmlHyperlink(browserWIndow.CurrentDocumentWindow);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "newTabHyperlink");
            // start a new tab by clicking the button
            Mouse.Click(link);
            // find the tab with the browser window so we can find HTML elements in the new TAB
            var browsertab = BrowserWindow.Locate("New Tab");
            HtmlDiv itemtofindOnNewTab = new HtmlDiv(browsertab);
            itemtofindOnNewTab.SearchProperties.Add(HtmlDiv.PropertyNames.Id, "itemToFind");

            Console.WriteLine(itemtofindOnNewTab.InnerText);

            Stopwatch ws = new Stopwatch();
            ws.Start();
            browsertab.Close();
            ws.Stop();
            Console.WriteLine("Closed the tab using browser control in {0} ms", ws.ElapsedMilliseconds);
            
        }

        [TestMethod]
        public void CloseTabUsingWindowsControl()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            var browserWIndow = BrowserWindow.Launch("http://localhost:7032/");

            // Search for the hyperlink button to open up a new tab
            // find the hyperlink to start a new tab
            HtmlHyperlink link = new HtmlHyperlink(browserWIndow.CurrentDocumentWindow);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "newTabHyperlink");
            // start a new tab by clicking the button
            Mouse.Click(link);
            // find the tab with the browser window so we can find HTML elements in the new TAB
            var browsertab = BrowserWindow.Locate("New Tab");
            HtmlDiv itemtofindOnNewTab = new HtmlDiv(browsertab);
            itemtofindOnNewTab.SearchProperties.Add(HtmlDiv.PropertyNames.Id, "itemToFind");

            Console.WriteLine(itemtofindOnNewTab.InnerText);


            // now find the tab and close it using a windows control
            Stopwatch ws = new Stopwatch();
            ws.Start();
            // get the tab strip in IE
            WinTabList tablist = new WinTabList(browserWIndow);
            WinTabPage newTab = new WinTabPage(tablist);
            // use contains option, since the tab wil contain the name and has some additional text
            newTab.SearchProperties.Add(WinTabPage.PropertyNames.Name, "New Tab", PropertyExpressionOperator.Contains);
            WinButton close = new WinButton(newTab);
            close.SearchProperties.Add(WinButton.PropertyNames.Name, "Close", PropertyExpressionOperator.Contains);
            Mouse.Click(close);
            ws.Stop();
            Console.WriteLine("Closed the tab using windows control in {0} ms", ws.ElapsedMilliseconds);

        }
        
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
