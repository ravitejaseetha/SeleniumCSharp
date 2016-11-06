namespace UITestAutomationPageObjects.PageObjects.Home.HomePageClasses
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using UITestAutomationPageObjects.PageObjects.Store.ShoppingCartClasses;
    using UITestAutomationPageObjects.PageObjects.Store.StoreBrowseClasses;
    using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using UITestAutomationPageObjects.PageObjects.Shared;


    public partial class HomePage : SharedActionsAndElements
    {
        
        public HomePage(BrowserWindow browserWindow):base(browserWindow)
        {
            
        }
        public StoreDetail SelectProduct(string productName)
        {
            var productList = GetProductList();
            var productHyperlink = new HtmlHyperlink(productList);
            productHyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            Mouse.Click(productHyperlink);
            return new StoreDetail(_browserWindow);
        }

        private HtmlControl GetProductList()
        {
            var AlbumList = new HtmlControl(_browserWindow);
            AlbumList.SearchProperties.Add(HtmlList.PropertyNames.Id, "album-list");
            AlbumList.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "UL");
            AlbumList.Find();
            return AlbumList;
        }

        public HtmlList FresshOfThegrillList
        {
            get
            {
                var fressOfGrillList = new HtmlList();
                fressOfGrillList.SearchProperties.Add(HtmlList.PropertyNames.Id, "album-list");
                fressOfGrillList.Find();
                return fressOfGrillList;
            }
        }
    }
}
