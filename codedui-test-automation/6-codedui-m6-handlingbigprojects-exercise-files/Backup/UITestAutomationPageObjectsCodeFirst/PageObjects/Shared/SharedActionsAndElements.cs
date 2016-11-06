using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationPageObjects.PageObjects.Store.StoreBrowseClasses;
using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
using UITestAutomationPageObjectsCodeFirst.PageObjects.Home;
using UITestAutomationPageObjectsCodeFirst.PageObjects.ShoppingCart;

namespace UITestAutomationPageObjects.PageObjects.Shared
{
    public class SharedActionsAndElements
    {
   
        protected BrowserWindow _browserWindow;

        public SharedActionsAndElements(BrowserWindow browserWindow)
        {
            _browserWindow = browserWindow;
        }

        public HomePage NavigateHome()
        {
            var homeHyperlink = new HtmlHyperlink(_browserWindow);
            homeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "current";
            Mouse.Click(homeHyperlink);
            return new HomePage(_browserWindow);
        }

        public ShoppingCart NavigateShoppingCart()
        {
            var shoppingcartHyperlink = new HtmlHyperlink(_browserWindow);
            shoppingcartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "cart-status";

            Mouse.Click(shoppingcartHyperlink);
            return new ShoppingCart(_browserWindow);
        }


        public StoreBrowse NavigateStore()
        {
            
            var storeHyperlink = new HtmlHyperlink(_browserWindow);
            storeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Store";
            Mouse.Click(storeHyperlink);
            return new StoreBrowse(_browserWindow);
        }

        public StoreBrowse Selectcategory(string categoryName)
        {
            // find the hyperlink in the list of categories
            var categoriesList = this.CategoryList;
            var categoryHyperlink = new HtmlHyperlink(categoriesList);
            categoryHyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, categoryName, PropertyExpressionOperator.Contains);
            Mouse.Click(categoryHyperlink);
            return new StoreBrowse(_browserWindow);
        }



        public HtmlCustom CategoryList
        {
            get
            {
                var categoryList = new HtmlCustom(_browserWindow);
                categoryList.SearchProperties.Add(HtmlCustom.PropertyNames.Id, "categories");
                categoryList.Find();
                return categoryList;
            }
        }
  
    }
}
