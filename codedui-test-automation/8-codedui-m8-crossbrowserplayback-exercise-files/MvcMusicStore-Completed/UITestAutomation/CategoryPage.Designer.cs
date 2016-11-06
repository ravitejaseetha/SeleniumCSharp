﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UITestAutomation.CategoryPageClasses
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
    public partial class CategoryPage
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
        #endregion
        
        #region Fields
        private UIBrowseAlbumsDocument mUIBrowseAlbumsDocument;
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
        public HtmlHyperlink UITheBestOfMenAtWorkHyperlink
        {
            get
            {
                if ((this.mUITheBestOfMenAtWorkHyperlink == null))
                {
                    this.mUITheBestOfMenAtWorkHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = " The Best Of Men At Work ";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Store/Details/1";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/Store/Details/1";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Store/Details/1\"";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUITheBestOfMenAtWorkHyperlink.WindowTitles.Add("Browse Albums");
                    #endregion
                }
                return this.mUITheBestOfMenAtWorkHyperlink;
            }
        }
        
        public HtmlHyperlink UIForThoseAboutToRockWHyperlink
        {
            get
            {
                if ((this.mUIForThoseAboutToRockWHyperlink == null))
                {
                    this.mUIForThoseAboutToRockWHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIForThoseAboutToRockWHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIForThoseAboutToRockWHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIForThoseAboutToRockWHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIForThoseAboutToRockWHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = " For Those About To Rock We Salute You ";
                    this.mUIForThoseAboutToRockWHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Store/Details/2";
                    this.mUIForThoseAboutToRockWHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIForThoseAboutToRockWHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/Store/Details/2";
                    this.mUIForThoseAboutToRockWHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIForThoseAboutToRockWHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Store/Details/2\"";
                    this.mUIForThoseAboutToRockWHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "2";
                    this.mUIForThoseAboutToRockWHyperlink.WindowTitles.Add("Browse Albums");
                    #endregion
                }
                return this.mUIForThoseAboutToRockWHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUITheBestOfMenAtWorkHyperlink;
        
        private HtmlHyperlink mUIForThoseAboutToRockWHyperlink;
        #endregion
    }
}
