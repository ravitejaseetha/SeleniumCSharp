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
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace TestNextSiblingUI
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
        public void CodedUITestNextSibling()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
           // Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
            var aut = ApplicationUnderTest.Launch(@"C:\Users\Raviteja\Downloads\codedui-testing-web-applications (1)\5-codedui-testing-web-exercise-files\UsingNextSibling\TestNextSiblingUIWin\bin\Debug\UsingNextSiblingWin.exe");
          var A = aut;
          var B = new WinEdit(A);
          B.SearchProperties.Add(WpfCustom.PropertyNames.Name, "B");
          B.DrawHighlight();
          var C = new WinEdit(B);
          C.SearchConfigurations.Add(SearchConfiguration.NextSibling);
          C.DrawHighlight();          
        }

        [TestMethod]
        public void CodedUITestWpfNextSibling()
        {
            var aut = ApplicationUnderTest.Launch(@"D:\dropbox\Dropbox\marcel-devries\CodedUI\Demos\UsingNextSibling\bin\Debug\UsingNextSibling.exe");

            var A = aut;
            var B = new WpfEdit(A);
            B.SearchProperties.Add(WpfCustom.PropertyNames.AutomationId, "B");
            B.DrawHighlight();
            var C = new WpfEdit(B);

            C.SearchConfigurations.Add(SearchConfiguration.NextSibling);
            C.DrawHighlight();
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
