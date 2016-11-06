namespace UITestAutomationPageObjects.PageObjects.Store.ShoppingCartClasses
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
    using UITestAutomationPageObjects.PageObjects.CheckOut.AdressAndPaymentClasses;
    using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
    using UITestAutomationPageObjects.PageObjects.Shared;
    using UITestAutomationPageObjects.PageObjects.Account.AccountLogonClasses;


    public partial class ShoppingCart : SharedActionsAndElements
    {
        // actions
        
        public AccountLogon CheckOut()
        {
            var checkOutHyperlink = this.UIShoppingCartWindowsIWindow.UIShoppingCartDocument.UIMainPane.UICheckoutHyperlink;
            Mouse.Click(checkOutHyperlink);
            return new AccountLogon();
        }

        public ShoppingCart RemoveItemFromCart(string productName)
        {
            HtmlRow productRow = FindRowForProduct(productName);
            // in this row find the hyperlink and click it;
            int rowIndex = productRow.RowIndex;
            // now find the hyperlink in the cell
            HtmlHyperlink removeLink = new HtmlHyperlink(productRow);
            removeLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Remove", PropertyExpressionOperator.Contains);
            Mouse.Click(removeLink);
            // return ourselves
            return this;
            
        }

        public StoreDetail ShowDetailsForProduct(string productName)
        {
            HtmlRow productRow = FindRowForProduct(productName);
            // in this row find the hyperlink and click it;
            int rowIndex = productRow.RowIndex;
            // now find the hyperlink in the cell
            HtmlHyperlink detailsLink = new HtmlHyperlink(productRow);
            detailsLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            Mouse.Click(detailsLink);
            // return page that we navigated to
            return new StoreDetail();
        }

        //controls
        public HtmlTable ShoppingCartTable
        {
            get{
                return this.UIShoppingCartWindowsIWindow.UIShoppingCartDocument.UIMainPane.UIItemTable;
            }
        }

        public HtmlCell CartTotal
        {
            get {
                return this.UIShoppingCartWindowsIWindow.UIShoppingCartDocument.UIItemCartTotal;
            }
        }


        private HtmlRow FindRowForProduct(string productName)
        {
            // find the row in the shopping cart table based on the product name
            HtmlRow productRow = new HtmlRow(this.ShoppingCartTable);
            productRow.SearchProperties.Add(HtmlRow.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            productRow.Find();
            return productRow;
        }
        
    }
}
