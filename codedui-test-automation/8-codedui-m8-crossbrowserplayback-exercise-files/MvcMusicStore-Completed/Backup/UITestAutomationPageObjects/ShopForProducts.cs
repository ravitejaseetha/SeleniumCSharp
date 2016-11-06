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
using UITestAutomationPageObjects.PageObjects.Home.HomePageClasses;


namespace UITestAutomationPageObjects
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ShopForProducts
    {

        [TestInitialize]
        public void TestInitialize()
        {  
            if (TestContext.Properties["__Tfs_TestConfigurationName__"] != null)    
            {        
                string selectedBrowser = TestContext.Properties["__Tfs_TestConfigurationName__"].ToString();
                if (!string.IsNullOrEmpty(selectedBrowser))        
                {            
                    // check if we selected IE, Firefox or chrome            
                    if (selectedBrowser == "IE")
                        return;            
                    BrowserWindow.CurrentBrowser = selectedBrowser;        
                }    
            }
        }

        public ShopForProducts()
        {
        }

        [TestMethod]
        public void ShopForAlbumViaCategory()
        {
            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/"));
            browserWindow.Maximized = true;
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            browserWindow.CloseOnPlaybackCleanup = false;
            var appUnderTest = ApplicationUnderTest.Launch("youreExefile.exe");
            appUnderTest.CloseOnPlaybackCleanup = false;
            HomePage siteHome = new HomePage();
            Assert.IsTrue(
            siteHome.Selectcategory("Alternative")
                .SelectProduct("Carry On")
                .AddItemToCart()
                .CheckOut()
                .IsCurrentPageValid()
                ,"Buy Alternative album 'Carry On' dit not return to the logon page");
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
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
