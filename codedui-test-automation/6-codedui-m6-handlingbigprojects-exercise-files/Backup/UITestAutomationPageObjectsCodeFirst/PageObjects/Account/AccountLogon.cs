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
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    
    
    public partial class AccountLogon
    {
        private BrowserWindow _bw;

        public AccountLogon()
        {
        }

        public AccountLogon(BrowserWindow bw)
        {
            _bw = bw;
        }
        public bool IsCurrentPageValid()
        {
            var loginButton = GetLoginButton();
            loginButton.Find();
            return loginButton.DisplayText == "Log On";
        }

        private HtmlInputButton GetLoginButton()
        {
            HtmlInputButton btn = new HtmlInputButton(_bw);
            btn.SearchProperties.Add(HtmlInputButton.PropertyNames.Type, "submit");
            btn.SearchProperties.Add(HtmlInputButton.PropertyNames.ValueAttribute, "Log On");
            return btn;
        }

        public AccountLogon LoginWithSendKeys(string userName, string passWord)
        {
            HtmlEdit txtUserName = new HtmlEdit(_bw);
            txtUserName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "UserName");
            Keyboard.SendKeys(txtUserName, userName);

            HtmlEdit txtPassWord = new HtmlEdit(_bw);
            txtPassWord.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "Password");
            Keyboard.SendKeys(txtPassWord, passWord);

            var btn = GetLoginButton();
            Mouse.Click(btn);
            return this;
        }

        public AccountLogon LoginWithSetProperty(string userName, string passWord)
        {
            HtmlEdit txtUserName = new HtmlEdit(_bw);
            txtUserName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "UserName");
            txtUserName.Text = userName;

            HtmlEdit txtPassWord = new HtmlEdit(_bw);
            txtPassWord.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "Password");
            txtPassWord.Text = passWord;

            var btn = GetLoginButton();
            Mouse.Click(btn);
            return this;
        }
    }
}
