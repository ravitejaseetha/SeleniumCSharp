namespace UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses
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
    
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using UITestAutomationPageObjects.PageObjects.Shared;
    using UITestAutomationPageObjectsCodeFirst.PageObjects.ShoppingCart;


    public partial class StoreDetail : SharedActionsAndElements
    {
        public StoreDetail(BrowserWindow browserWindow):base(browserWindow)
        {
        }
        public ShoppingCart AddItemToCart()
        {
            var AddItemLink = GetAddToCartLink();
            Mouse.Click(AddItemLink);
            return new ShoppingCart(_browserWindow);
        }

        private HtmlHyperlink GetAddToCartLink()
        {
            HtmlHyperlink CartHyperlink = new HtmlHyperlink(_browserWindow);
            CartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Add to cart";
            CartHyperlink.Find();
            return CartHyperlink;
        }

        public HtmlControl Header
        {
            get{
                HtmlControl Header = new HtmlControl(_browserWindow);
                Header.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "h2");
                Header.Find();
                return Header;
            }
        }
    }
}
