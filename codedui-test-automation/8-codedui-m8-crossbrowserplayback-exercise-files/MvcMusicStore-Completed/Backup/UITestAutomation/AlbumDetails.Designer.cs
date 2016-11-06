﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UITestAutomation.AlbumDetailsClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class AlbumDetails
    {
        
        #region Properties
        public UIAlbumTheBestOfMenAtWWindow UIAlbumTheBestOfMenAtWWindow
        {
            get
            {
                if ((this.mUIAlbumTheBestOfMenAtWWindow == null))
                {
                    this.mUIAlbumTheBestOfMenAtWWindow = new UIAlbumTheBestOfMenAtWWindow();
                }
                return this.mUIAlbumTheBestOfMenAtWWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIAlbumTheBestOfMenAtWWindow mUIAlbumTheBestOfMenAtWWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAlbumTheBestOfMenAtWWindow : BrowserWindow
    {
        
        public UIAlbumTheBestOfMenAtWWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Album - ", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Album - The Best Of Men At Work");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAlbumTheBestOfMenAtWDocument UIAlbumTheBestOfMenAtWDocument
        {
            get
            {
                if ((this.mUIAlbumTheBestOfMenAtWDocument == null))
                {
                    this.mUIAlbumTheBestOfMenAtWDocument = new UIAlbumTheBestOfMenAtWDocument(this);
                }
                return this.mUIAlbumTheBestOfMenAtWDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAlbumTheBestOfMenAtWDocument mUIAlbumTheBestOfMenAtWDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAlbumTheBestOfMenAtWDocument : HtmlDocument
    {
        
        public UIAlbumTheBestOfMenAtWDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Album - The Best Of Men At Work";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Store/Details/1";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:26641/Store/Details/1";
            this.WindowTitles.Add("Album - The Best Of Men At Work");
            #endregion
        }
        
        #region Properties
        public UIAlbumdetailsPane UIAlbumdetailsPane
        {
            get
            {
                if ((this.mUIAlbumdetailsPane == null))
                {
                    this.mUIAlbumdetailsPane = new UIAlbumdetailsPane(this);
                }
                return this.mUIAlbumdetailsPane;
            }
        }
        #endregion
        
        #region Fields
        private UIAlbumdetailsPane mUIAlbumdetailsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAlbumdetailsPane : HtmlDiv
    {
        
        public UIAlbumdetailsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "album-details";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Genre: Rock \r\n\r\nArtist: Men At Work \r\n\r\n";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"album-details\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "3";
            this.WindowTitles.Add("Album - The Best Of Men At Work");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIAddtocartHyperlink
        {
            get
            {
                if ((this.mUIAddtocartHyperlink == null))
                {
                    this.mUIAddtocartHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIAddtocartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIAddtocartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIAddtocartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIAddtocartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Add to cart";
                    this.mUIAddtocartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/ShoppingCart/AddToCart/1";
                    this.mUIAddtocartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIAddtocartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/ShoppingCart/AddToCart/1";
                    this.mUIAddtocartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIAddtocartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/ShoppingCart/AddToCart/1\" length=";
                    this.mUIAddtocartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIAddtocartHyperlink.WindowTitles.Add("Album - The Best Of Men At Work");
                    #endregion
                }
                return this.mUIAddtocartHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIAddtocartHyperlink;
        #endregion
    }
}