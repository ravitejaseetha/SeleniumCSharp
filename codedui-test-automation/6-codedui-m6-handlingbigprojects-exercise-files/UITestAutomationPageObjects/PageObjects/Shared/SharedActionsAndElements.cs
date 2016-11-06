using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationPageObjects.PageObjects.Home.HomePageClasses;
using UITestAutomationPageObjects.PageObjects.Store.StoreBrowseClasses;
using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
namespace UITestAutomationPageObjects.PageObjects.Shared
{
    public class SharedActionsAndElements
    {
        private SharedClasses.Shared sharedControls = null;

        public SharedActionsAndElements()
        {
            sharedControls = new SharedClasses.Shared();
        }

        public HomePage NavigateHome()
        {
            var homeHyperlink = sharedControls.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UIHomeHyperlink;
            Mouse.Click(homeHyperlink);
            return new HomePage();
        }

        public ShoppingCart.ShoppingCartClasses.ShoppingCart NavigateShoppingCart()
        {
            var shoppingcartHyperlink = sharedControls.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UICartHyperlink;
            Mouse.Click(shoppingcartHyperlink);
            return new ShoppingCart.ShoppingCartClasses.ShoppingCart();
        }

        public StoreBrowse NavigateStore()
        {
            var storeHyperlink = sharedControls.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UINavlistCustom.UIStoreHyperlink;
            Mouse.Click(storeHyperlink);
            return new StoreBrowse();
        }

        public StoreBrowse SelectCategory(string categoryName)
        {
            var categoryList = sharedControls.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UICategoriesCustom;
            var categoryHyperlink = new HtmlHyperlink(categoryList);
            categoryHyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, categoryName, PropertyExpressionOperator.Contains);
            Mouse.Click(categoryHyperlink);

            return new StoreBrowse();
        }  
    }
}
