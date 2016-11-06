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
    using UITestAutomationPageObjects.PageObjects.ShoppingCart.ShoppingCartClasses;
    

    public partial class StoreDetail : SharedActionsAndElements
    {
        public ShoppingCart AddItemToCart()
        {
            var AddItemLink = this.UIAlbumDetailWindow.UIAlbumDetailsDocument.UIAlbumdetailsPane.UIAddtocartHyperlink;
            Mouse.Click(AddItemLink);
            return new ShoppingCart();
        }
    }
}
