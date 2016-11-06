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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using UITestAutomationPageObjectsCodeFirst.PageObjects.Home;

namespace UITestAutomationPageObjects
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ShopForProducts
    {

        public ShopForProducts()
        {
        }

        [TestMethod]
        public void ShopForAlbumViaCategory()
        {
            BrowserWindow.CurrentBrowser = "Firefox";
            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/"));
            HomePage siteHome = new HomePage(browserWindow);
            
            Assert.IsTrue(
                    
                siteHome.Selectcategory("Alternative")
                .SelectProduct("Carry On")
                .AddItemToCart()
                .CheckOut().IsCurrentPageValid()

                ,"Expected to be on logon page");
        }


        [TestMethod]
        public void CheckIfItemIsPlacedInShoppingCart()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;

            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/"));
            
            HomePage siteHome = new HomePage(browserWindow);
            
            Assert.IsFalse(
                siteHome.Selectcategory("Rock")
                .SelectProduct("Greatest Hits I")
                .AddItemToCart()
                .NavigateHome()
                .Selectcategory("Rock")
                .SelectProduct("Greatest Hits II")
                .AddItemToCart()
                .NavigateHome()
                .Selectcategory("Rock")
                .SelectProduct("Greatest Hits")
                .AddItemToCart()
                .RemoveItemFromcart("Greatest Hits")
                .IsProductInCart("Greatest Hits")
                , "expected Greatest Hits to be removed from Cart");
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
