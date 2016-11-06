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
        public ShopForProducts()
        {
        }

        [TestMethod]
        public void ShopForAlbumViaCategoryUsingMaps()
        {
            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/"));
            HomePage siteHome = new HomePage();
    
            Assert.IsTrue(
            siteHome.Selectcategory("Alternative")
                .SelectProduct("Carry On")
                .AddItemToCart()
                .CheckOut()
                .IsCurrentPageValid()
                ,"Buy Alternative album 'Carry On' dit not return to the logon page");
        }

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
