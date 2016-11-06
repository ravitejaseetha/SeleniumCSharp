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
using System.Diagnostics;


namespace UITestControlOperationsWinForms
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
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm")+ "\t start");
            ApplicationUnderTest aut = ApplicationUnderTest.Launch(@"D:\dropbox\Dropbox\marcel-devries\CodedUI\Demos\ControlOperations\ControlOperationsWinForms\bin\Debug\ControlOperationsWinForms.exe");
            WinButton wb = new WinButton(aut);
            wb.SearchProperties.Add(WinButton.PropertyNames.Name, "Create Listbox");
            wb.SearchProperties.Add(WinButton.PropertyNames.Name, "Create Listbox", PropertyExpressionOperator.Contains);
            Mouse.Click(wb);
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm")+"\t Click");
            // now find the control that will apear after 5 seconds
            WinList wl = new WinList(aut);
            wl.SearchProperties.Add(WinList.PropertyNames.Name, "DynamicListbox");
            wl.WaitForControlExist(7000);
            // now click the button to wait for the control to become enabled
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm")+"\t Found control ");
            
            WinButton wb2 = new WinButton(aut);
            wb2.SearchProperties.Add(WinButton.PropertyNames.Name, "btnEnable");
            
            Mouse.Click(wb2);
            Debug.WriteLine( DateTime.Now.ToString("dd-MM-yyyy:ss:mm")+ "\t click btn 2 " );
            
            wl.WaitForControlEnabled(7000);
            wl.SelectedItemsAsString = "Blue";
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t blue selected ");
            
            WinButton wb3 = new WinButton(aut);
            wb3.SearchProperties.Add(WinButton.PropertyNames.Name, "Remove Listbox");
            Mouse.Click(wb3);
            Debug.WriteLine( DateTime.Now.ToString("dd-MM-yyyy:ss:mm")+"\t Click 3 ");

            if (wl.WaitForControlNotExist(7000))
            {
                // control is now gone, so assert true
                Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm")+"\t Control removed ");

                Assert.IsTrue(true);
            }
            else { Assert.IsTrue(false); }


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
