using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomationPageObjects.PageObjects.Account.AccountLogonClasses;
using UITestAutomationPageObjects.PageObjects.Shared;
using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;

namespace UITestAutomationPageObjectsCodeFirst.PageObjects.ShoppingCart
{
    public class ShoppingCart : SharedActionsAndElements
    {
        public ShoppingCart(BrowserWindow browserWindow)
            : base(browserWindow)
        {
        }

        public AccountLogon CheckOut()
        {
            var checkoutHyperLink = GetCheckOutHyperlink();
            Mouse.Click(checkoutHyperLink);
            return new AccountLogon(_browserWindow);
        }

        public ShoppingCart RemoveItemFromcart(string productName)
        {
            var productRow = FindRowForProduct(productName);
            HtmlHyperlink details = new HtmlHyperlink(productRow);
            details.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Remove", PropertyExpressionOperator.Contains);
            Mouse.Click(details);
            return this;
        }

        public StoreDetail ShowDetailsForProduct(string productName)
        {
            var productRow = FindRowForProduct(productName);
            HtmlHyperlink details = new HtmlHyperlink(productRow);
            details.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            Mouse.Click(details);
            return new StoreDetail(_browserWindow) ;
        }

        public bool IsProductInCart(string productName)
        {
            return FindRowForProduct(productName).TryFind();
        }


        private HtmlRow FindRowForProduct(string productName)
        {
            HtmlRow productRow= new HtmlRow(this.ShoppingCartTable);
            productRow.SearchProperties.Add(HtmlRow.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            return productRow;
        }

        private HtmlTable ShoppingCartTable
        {
            get
            {
                HtmlTable shoppingCartTable = new HtmlTable(_browserWindow);
                shoppingCartTable.SearchProperties.Add(HtmlTable.PropertyNames.InnerText, "Album Name", PropertyExpressionOperator.Contains);
               // shoppingCartTable.DrawHighlight();
                return shoppingCartTable;
            }
        }

        private HtmlHyperlink GetCheckOutHyperlink()
        {
            HtmlHyperlink checkout = new HtmlHyperlink(_browserWindow);
            checkout.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Checkout >>", PropertyExpressionOperator.Contains);
            return checkout;
        }
    }
}
