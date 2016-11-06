namespace UITestAutomationPageObjects.PageObjects.Account.AccountLogonClasses
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
    
    
    public partial class AccountLogon
    {
        public bool IsCurrentPageValid()
        {
            var loginButton = this.UILogOnWindowsInternetWindow.UILogOnDocument.UIMainPane.UILogOnButton;
            loginButton.Find();
            return loginButton.DisplayText == "Log On";
        }
    }
}
