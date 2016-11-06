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
using UITestAutomationPageObjectsCodeFirst.Helper;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

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
            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/"));

            HomePage siteHome = new HomePage(browserWindow);
            Assert.IsTrue(
            siteHome.Selectcategory("Alternative")
                .SelectProduct("Carry On")
                .AddItemToCart()
                .CheckOut()
                .IsCurrentPageValid()
                , "Buy Alternative album 'Carry On' dit not return to the logon page");
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



        [TestMethod]
        public void testWithSeleniumLikeSyntaxCodedUI()
        {
            var driver = BrowserWindow.Launch(new Uri("http://localhost:26641/"));

            driver.resizeWindow(400, 200);

            driver.FindElement(By.Id("current")).Click();
            // search for an A with inner text == Rock
            var element = (driver.FindElements(By.ClassName("categories"))
                .Where(e =>
                    {
                        var htmlcontrol = e as HtmlControl;
                        return htmlcontrol.InnerText.Contains("Rock");
                    }
                    )).FirstOrDefault();

            element.Click();

        }

    }
}
