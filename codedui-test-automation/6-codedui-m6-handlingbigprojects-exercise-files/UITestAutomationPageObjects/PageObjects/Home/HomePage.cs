namespace UITestAutomationPageObjects.PageObjects.Home.HomePageClasses
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
using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
    using UITestAutomationPageObjects.PageObjects.Shared;


    public partial class HomePage : SharedActionsAndElements
    {


        public StoreDetail SelectProduct(string productName)
        {
            return SelectProductFromAlbumList(productName);
        }

        public StoreDetail SelectProductfromfreshOftheGril(string productName)
        {
            return SelectProductFromAlbumList(productName);
        }

        public bool IsProductPartOfFreshOfTheGrill(string productName)
        {
            return FindProductOnPage(productName).TryFind();
        }

        private StoreDetail SelectProductFromAlbumList(string productName)
        {
            var productHyperlink = FindProductOnPage(productName);
            Mouse.Click(productHyperlink);
            return new StoreDetail();
        }


        private HtmlHyperlink FindProductOnPage(string productName)
        {
            var productList = this.UIASPNETMVCMusicStoreWWindow.UIASPNETMVCMusicStoreDocument.UIAlbumlistCustom;
            var productHyperlink = new HtmlHyperlink(productList);
            productHyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            return productHyperlink;
        }
    }
}
