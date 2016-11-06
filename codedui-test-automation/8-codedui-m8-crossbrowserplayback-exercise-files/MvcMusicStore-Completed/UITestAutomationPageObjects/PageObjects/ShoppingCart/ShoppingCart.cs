namespace UITestAutomationPageObjects.PageObjects.ShoppingCart.ShoppingCartClasses
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
using UITestAutomationPageObjects.PageObjects.Account.AccountLogonClasses;
using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
    using UITestAutomationPageObjects.PageObjects.Shared;


    public partial class ShoppingCart : SharedActionsAndElements
    {
        public AccountLogon CheckOut()
        {
            var checkOutHyperLink = this.UIShoppingCartWindowsIWindow.UIShoppingCartDocument.UIMainPane.UICheckoutHyperlink;
            Mouse.Click(checkOutHyperLink);
            return new AccountLogon();
        }

        public ShoppingCart RemoveItemFromCart(string productName)
        {
            HtmlRow productRow = FindRowForProduct(productName);

            var removeHyperLink = new HtmlHyperlink(productRow);
            removeHyperLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Remove", PropertyExpressionOperator.Contains);

            Mouse.Click(removeHyperLink);

            return this;
        }


        public StoreDetail ShowDetailsForProduct(string productName)
        {
            HtmlRow productRow = FindRowForProduct(productName);
            var productHyperLink = new HtmlHyperlink(productRow);
            productHyperLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);

            Mouse.Click(productHyperLink);

            return new StoreDetail();
        }

        public bool IsProductInShoppingCart(string productName)
        {
            return FindRowForProduct(productName).TryFind();
        }

        public bool IsNumberOfItemsInCart(int numberOfItems)
        {
            return this.ShoppingCartTable.RowCount - 2 == numberOfItems;
        }


        private HtmlTable ShoppingCartTable
        {
            get 
            {
                return this.UIShoppingCartWindowsIWindow.UIShoppingCartDocument.UIMainPane.UIItemTable;
            }
        }

        private HtmlRow FindRowForProduct(string productName)
        {
            HtmlRow productRow = new HtmlRow(this.ShoppingCartTable);
            productRow.SearchProperties.Add(HtmlRow.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            return productRow;
        }
    }
}
