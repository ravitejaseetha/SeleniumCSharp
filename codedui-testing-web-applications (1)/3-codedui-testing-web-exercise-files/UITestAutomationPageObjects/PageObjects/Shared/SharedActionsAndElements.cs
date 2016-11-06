using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationPageObjects.PageObjects.Home.HomePageClasses;
using UITestAutomationPageObjects.PageObjects.Store.ShoppingCartClasses;
using UITestAutomationPageObjects.PageObjects.Store.StoreBrowseClasses;
using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;

namespace UITestAutomationPageObjects.PageObjects.Shared
{
    public class SharedActionsAndElements
    {
        HomePage hp = null;

        public HomePage NavigateHome()
        {
            if (hp == null) hp= new HomePage();
            var homeHyperlink = hp.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UINavlistCustom.UIHomeHyperlink;
            Mouse.Click(homeHyperlink);
            return hp;
        }

        public ShoppingCart NavigateShoppingCart()
        {
            if (hp == null) hp = new HomePage();
            var shoppingcartHyperlink = hp.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UINavlistCustom.UICartHyperlink;
            Mouse.Click(shoppingcartHyperlink);
            return new ShoppingCart();
        }

        public StoreBrowse NavigateStore()
        {
            if (hp == null) hp = new HomePage();
            var storeHyperlink = hp.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UINavlistCustom.UIStoreHyperlink;
            Mouse.Click(storeHyperlink);
            return new StoreBrowse();
        }

        public StoreBrowse Selectcategory(string categoryName)
        {
            if (hp == null) hp = new HomePage();
            var categoryList = hp.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UICategoriesCustom;
            var categoryHyperlink = new HtmlHyperlink(categoryList);
            categoryHyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, categoryName, PropertyExpressionOperator.Contains);
            Mouse.Click(categoryHyperlink);

            return new StoreBrowse();
        }       

        public HtmlList CategoryList
        {
            get
            {
                if (hp == null) hp = new HomePage();
                var categoryList = new HtmlList(hp.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument);
                categoryList.SearchProperties.Add(HtmlList.PropertyNames.Id, "categories");
                categoryList.Find();
                return categoryList;
            }
        }
  
    }
}
