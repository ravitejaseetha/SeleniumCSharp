﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UITestAutomationPageObjects.PageObjects.CheckOut.AdressAndPaymentClasses
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
    public partial class AdressAndPayment
    {
        
        #region Properties
        public UIAddressAndPaymentWinWindow UIAddressAndPaymentWinWindow
        {
            get
            {
                if ((this.mUIAddressAndPaymentWinWindow == null))
                {
                    this.mUIAddressAndPaymentWinWindow = new UIAddressAndPaymentWinWindow();
                }
                return this.mUIAddressAndPaymentWinWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIAddressAndPaymentWinWindow mUIAddressAndPaymentWinWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAddressAndPaymentWinWindow : BrowserWindow
    {
        
        public UIAddressAndPaymentWinWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Address And Payment";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Address And Payment");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAddressAndPaymentDocument UIAddressAndPaymentDocument
        {
            get
            {
                if ((this.mUIAddressAndPaymentDocument == null))
                {
                    this.mUIAddressAndPaymentDocument = new UIAddressAndPaymentDocument(this);
                }
                return this.mUIAddressAndPaymentDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAddressAndPaymentDocument mUIAddressAndPaymentDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAddressAndPaymentDocument : HtmlDocument
    {
        
        public UIAddressAndPaymentDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Address And Payment";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Checkout/AddressAndPayment";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:26641/Checkout/AddressAndPayment";
            this.WindowTitles.Add("Address And Payment");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIFirstNameEdit
        {
            get
            {
                if ((this.mUIFirstNameEdit == null))
                {
                    this.mUIFirstNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIFirstNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "FirstName";
                    this.mUIFirstNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "FirstName";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "First Name";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FirstName\" class=\"text-box single-";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUIFirstNameEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUIFirstNameEdit;
            }
        }
        
        public HtmlEdit UILastNameEdit
        {
            get
            {
                if ((this.mUILastNameEdit == null))
                {
                    this.mUILastNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUILastNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "LastName";
                    this.mUILastNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "LastName";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Last Name";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"LastName\" class=\"text-box single-l";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUILastNameEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUILastNameEdit;
            }
        }
        
        public HtmlEdit UIAddressEdit
        {
            get
            {
                if ((this.mUIAddressEdit == null))
                {
                    this.mUIAddressEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIAddressEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address";
                    this.mUIAddressEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Address";
                    this.mUIAddressEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Address";
                    this.mUIAddressEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIAddressEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIAddressEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIAddressEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Address\" class=\"text-box single-li";
                    this.mUIAddressEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    this.mUIAddressEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUIAddressEdit;
            }
        }
        
        public HtmlEdit UICityEdit
        {
            get
            {
                if ((this.mUICityEdit == null))
                {
                    this.mUICityEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUICityEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "City";
                    this.mUICityEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "City";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "City";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"City\" class=\"text-box single-line\"";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "4";
                    this.mUICityEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUICityEdit;
            }
        }
        
        public HtmlEdit UIStateEdit
        {
            get
            {
                if ((this.mUIStateEdit == null))
                {
                    this.mUIStateEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIStateEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "State";
                    this.mUIStateEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "State";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "State";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"State\" class=\"text-box single-line";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "5";
                    this.mUIStateEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUIStateEdit;
            }
        }
        
        public HtmlEdit UIPostalCodeEdit
        {
            get
            {
                if ((this.mUIPostalCodeEdit == null))
                {
                    this.mUIPostalCodeEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIPostalCodeEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "PostalCode";
                    this.mUIPostalCodeEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "PostalCode";
                    this.mUIPostalCodeEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Postal Code";
                    this.mUIPostalCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIPostalCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIPostalCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIPostalCodeEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"PostalCode\" class=\"text-box single";
                    this.mUIPostalCodeEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "6";
                    this.mUIPostalCodeEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUIPostalCodeEdit;
            }
        }
        
        public HtmlEdit UICountryEdit
        {
            get
            {
                if ((this.mUICountryEdit == null))
                {
                    this.mUICountryEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUICountryEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Country";
                    this.mUICountryEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Country";
                    this.mUICountryEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Country";
                    this.mUICountryEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUICountryEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUICountryEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUICountryEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Country\" class=\"text-box single-li";
                    this.mUICountryEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "7";
                    this.mUICountryEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUICountryEdit;
            }
        }
        
        public HtmlEdit UIPhoneEdit
        {
            get
            {
                if ((this.mUIPhoneEdit == null))
                {
                    this.mUIPhoneEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIPhoneEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Phone";
                    this.mUIPhoneEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Phone";
                    this.mUIPhoneEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Phone";
                    this.mUIPhoneEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIPhoneEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIPhoneEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIPhoneEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Phone\" class=\"text-box single-line";
                    this.mUIPhoneEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "8";
                    this.mUIPhoneEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUIPhoneEdit;
            }
        }
        
        public HtmlEdit UIEmailAddressEdit
        {
            get
            {
                if ((this.mUIEmailAddressEdit == null))
                {
                    this.mUIEmailAddressEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIEmailAddressEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Email";
                    this.mUIEmailAddressEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Email";
                    this.mUIEmailAddressEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Email Address";
                    this.mUIEmailAddressEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIEmailAddressEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIEmailAddressEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIEmailAddressEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Email\" class=\"text-box single-line";
                    this.mUIEmailAddressEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "9";
                    this.mUIEmailAddressEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUIEmailAddressEdit;
            }
        }
        
        public HtmlEdit UIPromoCodeEdit
        {
            get
            {
                if ((this.mUIPromoCodeEdit == null))
                {
                    this.mUIPromoCodeEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIPromoCodeEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "PromoCode";
                    this.mUIPromoCodeEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "PromoCode";
                    this.mUIPromoCodeEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUIPromoCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIPromoCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIPromoCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = null;
                    this.mUIPromoCodeEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"PromoCode\" id=\"PromoCode\" type=\"te";
                    this.mUIPromoCodeEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "10";
                    this.mUIPromoCodeEdit.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUIPromoCodeEdit;
            }
        }
        
        public UIMainPane UIMainPane
        {
            get
            {
                if ((this.mUIMainPane == null))
                {
                    this.mUIMainPane = new UIMainPane(this);
                }
                return this.mUIMainPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIFirstNameEdit;
        
        private HtmlEdit mUILastNameEdit;
        
        private HtmlEdit mUIAddressEdit;
        
        private HtmlEdit mUICityEdit;
        
        private HtmlEdit mUIStateEdit;
        
        private HtmlEdit mUIPostalCodeEdit;
        
        private HtmlEdit mUICountryEdit;
        
        private HtmlEdit mUIPhoneEdit;
        
        private HtmlEdit mUIEmailAddressEdit;
        
        private HtmlEdit mUIPromoCodeEdit;
        
        private UIMainPane mUIMainPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMainPane : HtmlDiv
    {
        
        public UIMainPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "main";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Address And Payment\r\n\r\nShipping Informat";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"main\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "2";
            this.WindowTitles.Add("Address And Payment");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UISubmitOrderButton
        {
            get
            {
                if ((this.mUISubmitOrderButton == null))
                {
                    this.mUISubmitOrderButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUISubmitOrderButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUISubmitOrderButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUISubmitOrderButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Submit Order";
                    this.mUISubmitOrderButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUISubmitOrderButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUISubmitOrderButton.FilterProperties[HtmlButton.PropertyNames.Class] = null;
                    this.mUISubmitOrderButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "type=\"submit\" value=\"Submit Order\"";
                    this.mUISubmitOrderButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "11";
                    this.mUISubmitOrderButton.WindowTitles.Add("Address And Payment");
                    #endregion
                }
                return this.mUISubmitOrderButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUISubmitOrderButton;
        #endregion
    }
}
