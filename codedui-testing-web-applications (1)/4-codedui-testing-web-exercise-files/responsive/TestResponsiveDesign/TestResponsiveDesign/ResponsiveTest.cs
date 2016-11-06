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
using TestResponsiveDesign;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace TestResponsiveDesign
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ResponsiveTest
    {
        public ResponsiveTest()
        {
        }

        [TestMethod]
        public void ValidateMenuChange()
        {
            var bw = BrowserWindow.Launch(new Uri("https://mvpready.com/"));
            bw.Maximized = true;
            
            // find the support hyperlink menu
            HtmlHyperlink link = new HtmlHyperlink(bw);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Support");
            // now set the control to always search and eliminate the cache
            // so it will search again when I resize the window
            link.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            Mouse.Click(link);

            // now resize the browserwindow to the size of the mobile device
            // e.g.:
            // QVGA: quarter VGA (240×320 pixels)
            // HVGA: half VGA (320×480 pixels)
            // WVGA: wide VGA (480×800 pixels)
            // FWVGA: full wide VGA (480×854 pixels)
            // nHD: one-ninth high definition (360×640 pixels)
            // qHD: one-quarter high definition (540×960 pixels)
            bw.ResizeWindow(480, 800);
            // now go back and try again
            bw.Back();
            // now try and search for the control again, this should fail, because 
            // it is now initialy hidden
            // I need to reveal it first before I can click
            bool exceptionraised = false;
            try
            {
                Mouse.Click(link);
            }
            catch (Exception) { exceptionraised = true; }

            // and now check there is a hamburger button instead

            HtmlButton hamburgerBtn = new HtmlButton(bw);
            hamburgerBtn.SearchProperties.Add(HtmlButton.PropertyNames.Class, "navbar-toggle");
            Mouse.Click(hamburgerBtn);

            // if we could click the hamburger button and we did get an exception on clicking
            // the link when we search the second time, we know the UI adapted to the new size
            Assert.IsTrue(exceptionraised);

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
