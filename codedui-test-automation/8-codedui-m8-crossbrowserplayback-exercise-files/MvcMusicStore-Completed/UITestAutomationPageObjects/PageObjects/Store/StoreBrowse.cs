namespace UITestAutomationPageObjects.PageObjects.Store.StoreBrowseClasses
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
    using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using UITestAutomationPageObjects.PageObjects.Shared;


    public partial class StoreBrowse : SharedActionsAndElements
    {
        public StoreDetail SelectProduct(string productName)
        {
            var productList = this.UIBrowseAlbumsWindowsIWindow.UIBrowseAlbumsDocument.UIMainPane;
            //productList.DrawHighlight();

            HtmlHyperlink productLink = new HtmlHyperlink(productList);
            productLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            Mouse.Click(productLink);
            return new StoreDetail();
        }
    }
}
