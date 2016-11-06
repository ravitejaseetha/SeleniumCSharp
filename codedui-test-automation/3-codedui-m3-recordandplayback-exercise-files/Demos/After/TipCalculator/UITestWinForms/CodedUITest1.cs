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


namespace UITestWinForms
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
        public void HandCoded()
        {


            ApplicationUnderTest aut = ApplicationUnderTest.Launch(@"C:\Users\Marcel\Dropbox\marcel-devries\CodedUI\Demos\TipCalculator\TipCalculatorWinForms\bin\Debug\TipCalculatorWinForms.exe");
            
            WinComboBox cbBox = new WinComboBox(aut);
            cbBox.SearchProperties.Add(WinComboBox.PropertyNames.Name, "cmbCountries");
            cbBox.SelectedItem = "United States";
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            ApplicationUnderTest aut = ApplicationUnderTest.Launch(@"D:\dropbox\Dropbox\marcel-devries\CodedUI\Demos\TipCalculator\TipCalculatorWinForms\bin\Debug\TipCalculatorWinForms.exe");
            
            MainFormClasses.MainForm form = new MainFormClasses.MainForm();
            form.CalculateNetherlands200();

            form.AssertNetherlands200BadService();
        }

        [TestMethod]
        public void WithAlternativeValues()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            ApplicationUnderTest aut = ApplicationUnderTest.Launch(@"D:\dropbox\Dropbox\marcel-devries\CodedUI\Demos\TipCalculator\TipCalculatorWinForms\bin\Debug\TipCalculatorWinForms.exe");

            MainFormClasses.MainForm form = new MainFormClasses.MainForm();
            form.CalculateNetherlands200Params.UITxtBillAmountEditText = "200";
            form.CalculateNetherlands200();

            form.AssertNetherlands200BadServiceExpectedValues.UITxtTotalAmountEditText = "220.00";
            form.AssertNetherlands200BadService();
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
