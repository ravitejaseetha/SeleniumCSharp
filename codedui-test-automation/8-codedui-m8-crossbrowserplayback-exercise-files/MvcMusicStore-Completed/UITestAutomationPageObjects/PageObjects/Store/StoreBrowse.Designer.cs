﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UITestAutomationPageObjects.PageObjects.Store.StoreBrowseClasses
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
    public partial class StoreBrowse
    {
        
        #region Properties
        public UIBrowseAlbumsWindowsIWindow UIBrowseAlbumsWindowsIWindow
        {
            get
            {
                if ((this.mUIBrowseAlbumsWindowsIWindow == null))
                {
                    this.mUIBrowseAlbumsWindowsIWindow = new UIBrowseAlbumsWindowsIWindow();
                }
                return this.mUIBrowseAlbumsWindowsIWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIBrowseAlbumsWindowsIWindow mUIBrowseAlbumsWindowsIWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBrowseAlbumsWindowsIWindow : BrowserWindow
    {
        
        public UIBrowseAlbumsWindowsIWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Browse Albums";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Browse Albums");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIBrowseAlbumsDocument UIBrowseAlbumsDocument
        {
            get
            {
                if ((this.mUIBrowseAlbumsDocument == null))
                {
                    this.mUIBrowseAlbumsDocument = new UIBrowseAlbumsDocument(this);
                }
                return this.mUIBrowseAlbumsDocument;
            }
        }
        
        public UIBrowseAlbumsDocument1 UIBrowseAlbumsDocument1
        {
            get
            {
                if ((this.mUIBrowseAlbumsDocument1 == null))
                {
                    this.mUIBrowseAlbumsDocument1 = new UIBrowseAlbumsDocument1(this);
                }
                return this.mUIBrowseAlbumsDocument1;
            }
        }
        #endregion
        
        #region Fields
        private UIBrowseAlbumsDocument mUIBrowseAlbumsDocument;
        
        private UIBrowseAlbumsDocument1 mUIBrowseAlbumsDocument1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBrowseAlbumsDocument : HtmlDocument
    {
        
        public UIBrowseAlbumsDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Browse Albums";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Store/Browse";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:26641/Store/Browse?Genre=Rock";
            this.WindowTitles.Add("Browse Albums");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIMainPane
        {
            get
            {
                if ((this.mUIMainPane == null))
                {
                    this.mUIMainPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIMainPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "main";
                    this.mUIMainPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIMainPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Rock Albums\r\n The Best Of Men At Work  \r";
                    this.mUIMainPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIMainPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIMainPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"main\"";
                    this.mUIMainPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "2";
                    this.mUIMainPane.WindowTitles.Add("Browse Albums");
                    #endregion
                }
                return this.mUIMainPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIMainPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBrowseAlbumsDocument1 : HtmlDocument
    {
        
        public UIBrowseAlbumsDocument1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Browse Albums";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Store/Browse";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:26641/Store/Browse?Genre=Alternative";
            this.WindowTitles.Add("Browse Albums");
            #endregion
        }
        
        #region Properties
        public UIAlbumlistCustom UIAlbumlistCustom
        {
            get
            {
                if ((this.mUIAlbumlistCustom == null))
                {
                    this.mUIAlbumlistCustom = new UIAlbumlistCustom(this);
                }
                return this.mUIAlbumlistCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIAlbumlistCustom mUIAlbumlistCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAlbumlistCustom : HtmlCustom
    {
        
        public UIAlbumlistCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "UL";
            this.SearchProperties["Id"] = "album-list";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"album-list\"";
            this.FilterProperties["TagInstance"] = "3";
            this.WindowTitles.Add("Browse Albums");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIRevelationsHyperlink
        {
            get
            {
                if ((this.mUIRevelationsHyperlink == null))
                {
                    this.mUIRevelationsHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIRevelationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIRevelationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIRevelationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIRevelationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = " Revelations ";
                    this.mUIRevelationsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Store/Details/232";
                    this.mUIRevelationsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIRevelationsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/Store/Details/232";
                    this.mUIRevelationsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIRevelationsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Store/Details/232\"";
                    this.mUIRevelationsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIRevelationsHyperlink.WindowTitles.Add("Browse Albums");
                    #endregion
                }
                return this.mUIRevelationsHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIRevelationsHyperlink;
        #endregion
    }
}
