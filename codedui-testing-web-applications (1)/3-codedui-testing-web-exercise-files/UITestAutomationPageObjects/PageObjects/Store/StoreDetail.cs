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
    using UITestAutomationPageObjects.PageObjects.Store.ShoppingCartClasses;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using UITestAutomationPageObjects.PageObjects.Shared;


    public partial class StoreDetail : SharedActionsAndElements
    {
        public ShoppingCart AddItemToCart()
        {
            var AddItemLink = this.UIAlbumDetailWindow.UIAlbumDetailsDocument.UIAlbumdetailsPane.UIAddtocartHyperlink;
            Mouse.Click(AddItemLink);
            return new ShoppingCart();
        }

        public HtmlControl Header
        {
            get{
                HtmlControl Header = new HtmlControl(this.UIAlbumDetailWindow.UIAlbumDetailsDocument.UIMainPane);
                Header.SearchProperties.Add(HtmlControl.PropertyNames.TagName, "h2");
                Header.Find();
                return Header;
            }
        }
    }
}
