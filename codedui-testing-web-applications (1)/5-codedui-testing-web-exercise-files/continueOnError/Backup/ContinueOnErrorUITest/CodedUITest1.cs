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


namespace ContinueOnErrorUITest
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            int iterationCount = 0;
            var aut = ApplicationUnderTest.Launch(@"D:\dropbox\Dropbox\marcel-devries\CodedUI\Demos\continueOnError\bin\Debug\continueOnError.exe");
            var edit = new WinEdit(aut);
            edit.SearchProperties.Add(WinEdit.PropertyNames.Name, "txtInfo");

            edit.Text = "Value Edited #" +iterationCount++;

            WinButton btn = new WinButton(aut);
            btn.SearchProperties.Add(WinButton.PropertyNames.Name, "btnShowMessage");
            Mouse.Click(btn);

            // now we expect an dialog and we want to click it away
            var msgBox = new MessageBoxClasses.MessageBox();
            var btnmsgBox = msgBox.UIOKWindow.UIOKButton;
            Mouse.Click(btnmsgBox);

            edit.Text = "Value Edited #" + iterationCount++;
            // now we click again, but the message box will not apear
            Mouse.Click(btn);
            // this action will fail
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(btnmsgBox);

            edit.Text = "Value Edited #" + iterationCount++;
            Mouse.Click(btn);
            // this action should succeed
            Mouse.Click(btnmsgBox);


        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
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
