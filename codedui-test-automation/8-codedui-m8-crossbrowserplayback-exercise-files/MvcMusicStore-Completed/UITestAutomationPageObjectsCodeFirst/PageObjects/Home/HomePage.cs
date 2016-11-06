using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationPageObjects.PageObjects.Shared;
using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;

namespace UITestAutomationPageObjectsCodeFirst.PageObjects.Home
{
    public class HomePage : SharedActionsAndElements
    {
        public HomePage(BrowserWindow browserWindow)
            : base(browserWindow)
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
            var albumList = new HtmlControl(_browserWindow);
            albumList.SearchProperties.Add(HtmlControl.PropertyNames.Id, "album-list");
            return albumList;
        }

    }
}
