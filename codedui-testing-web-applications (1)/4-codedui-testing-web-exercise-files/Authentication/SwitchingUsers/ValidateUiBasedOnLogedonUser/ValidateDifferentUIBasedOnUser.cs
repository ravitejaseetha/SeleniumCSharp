using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.Win32;


namespace ValidateUiBasedOnLogedonUser
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ValidateDifferentUIBasedOnUser
    {
        private  object originalRegistryValue = null;
        private const  string RegistryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\1";
   
        public ValidateDifferentUIBasedOnUser()
        {
        }

        [TestInitialize]
        public  void Initialize()
        { 
            originalRegistryValue = Registry.GetValue(RegistryKey,"1A00",null);
            // set the value to always ask for credentials
            Registry.SetValue(RegistryKey, "1A00", 0x10000);
        }

        [TestCleanup]
        public  void Cleanup()
        {
           Registry.SetValue(RegistryKey, "1A00", originalRegistryValue);
        }

        [TestMethod]
        public void ValidateHyperlinkExistsUser1()
        {
            Assert.IsTrue(FindHyperlinkbasedOnUser("user1","P2ssw0rd"));
        }

        [TestMethod]
        public void ValidateHyperlinkNotExistsUser2()
        {
            Assert.IsFalse(FindHyperlinkbasedOnUser("user2", "P2ssw0rd"));
        }

        private static bool FindHyperlinkbasedOnUser(string userName, string passWord)
        {
            var b = BrowserWindow.Launch(new Uri("http://localhost:2630/"));
            // now enter credentials in windows logon dialog

            EnterCredentials(userName, passWord);

            // now check if hyperlink is there
            return FindHyperlink(b);
        }

        private static void EnterCredentials(string userName, string passWord)
        {
            WinWindow window = FindSecurityDialog();
            // now the list of credential options, pick the first
            WinListItem listItem = FindCredentialOption(window);

            // now find the edit boxes to fill out the username and password
            WinEdit UserNameEdit = FindUserNameedit(listItem);
            UserNameEdit.Text = userName;

            WinEdit PassWordEdit = FindPasswordEdit(listItem);
            PassWordEdit.Text = passWord;

            // click ok

            WinButton okButton = FindOkButton(window);
            okButton.WindowTitles.Add("Windows Security");

            Mouse.Click(okButton);

            // now check if we don't get a new security dialog, 
            // if we still keep the dialog, we
            // failed logging on to the website
            if (!FindSecurityDialog().WaitForControlNotExist(5000))
                throw new InvalidOperationException("Unable to login to the website with provided credentials");

        }

        private static bool FindHyperlink(BrowserWindow b)
        {
            HtmlHyperlink LearnMoreLink = new HtmlHyperlink(b);
            LearnMoreLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "LearnMore");
            return LearnMoreLink.TryFind();
        }
 
        private static WinButton FindOkButton(WinWindow window)
        {
            WinPane securityPane = new WinPane(window);
            securityPane.SearchProperties.Add(WinControl.PropertyNames.Name, "Windows Security");
            securityPane.WindowTitles.Add("Windows Security");

            WinButton okButton = new WinButton(securityPane);
            okButton.SearchProperties.Add(WinButton.PropertyNames.Name, "OK");
            return okButton;
        }

        private static WinEdit FindPasswordEdit(WinListItem listItem)
        {
            WinEdit PassWordEdit = new WinEdit(listItem);
            PassWordEdit.SearchProperties.Add(WinEdit.PropertyNames.Name, "Password");
            PassWordEdit.WindowTitles.Add("Windows Security");
            return PassWordEdit;
        }

        private static WinEdit FindUserNameedit(WinListItem listItem)
        {
            WinEdit UserNameEdit = new WinEdit(listItem);
            UserNameEdit.SearchProperties.Add(WinEdit.PropertyNames.Name, "User name");
            UserNameEdit.WindowTitles.Add("Windows Security");
            return UserNameEdit;
        }

        private static WinListItem FindCredentialOption(WinWindow window)
        {
            WinListItem listItem = new WinListItem(window);
            listItem.SearchProperties.Add(WinListItem.PropertyNames.Name, "Use another account");
            listItem.WindowTitles.Add("Windows Security");
            return listItem;
        }

        private static WinWindow FindSecurityDialog()
        {
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.ClassName, "#32770");
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, "Windows Security");
            window.WindowTitles.Add("Windows Security");
            return window;
        }
       
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
