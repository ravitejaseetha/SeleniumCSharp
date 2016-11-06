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
using UITestAutomation.CategoryPageClasses;
using UITestAutomation.AlbumDetailsClasses;
using UITestAutomation.HomePageClasses;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace UITestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ValidateHomepage
    {
        public ValidateHomepage()
        {
        }
        [TestMethod]
        public void BuyOneItemRockHandCoded()
        {
            
            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/"));
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            
            HtmlHyperlink link = new HtmlHyperlink(browserWindow);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Rock");
            Mouse.Click(link);

            HtmlHyperlink link2 = new HtmlHyperlink(browserWindow);
            link2.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "For Those About To Rock We Salute You");

            Mouse.Click(link2);

            HtmlHyperlink link3 = new HtmlHyperlink(browserWindow);
            link2.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Add to cart");
            Mouse.Click(link3);

        }
        [TestMethod]
        public void BuyOneItemRock()
        {
            // scenario
            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/"));
            // browse to rock category
            var rockCategory = HomePage.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UICategoriesCustom.UIRockHyperlink;
            Mouse.Click(rockCategory);


            var album = CategoryPage.UIBrowseAlbumsWindowsIWindow.UIBrowseAlbumsDocument.UIAlbumlistCustom.UIForThoseAboutToRockWHyperlink;
            Mouse.Click(album);


            var albumDetails = AlbumDetails.UIAlbumTheBestOfMenAtWWindow.UIAlbumTheBestOfMenAtWDocument.UIAlbumdetailsPane.UIAddtocartHyperlink;
            Mouse.Click(albumDetails);
            // buy one item
            // checkout item
            // use existing account marcelv
            // use promocode FREE


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

        public HomePage HomePage
        {
            get
            {
                if ((this._map == null))
                {
                    this._map = new HomePage();
                }

                return this._map;
            }
        }

        private HomePage _map;

        private CategoryPage _categoryPage;
        public CategoryPage CategoryPage
        {
            get
            {
                if (_categoryPage == null)
                {
                    _categoryPage = new CategoryPage();
                }
                return _categoryPage;
            }
        }


        private AlbumDetails _albumDetails;
        public AlbumDetails AlbumDetails
        {
            get
            {
                if (_albumDetails == null)
                {
                    _albumDetails = new AlbumDetails();
                }
                return _albumDetails;
            }
        }
    }
}
