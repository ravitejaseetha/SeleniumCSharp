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
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace PerformanceDemoTest
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class LookupTest
    {
        public LookupTest()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            var bw = BrowserWindow.Launch(new Uri("http://localhost:2640/TableToSearch.html"));
            HtmlTable table = new HtmlTable(bw);
            table.SearchProperties.Add(HtmlTable.PropertyNames.Id, "LookupTable");

            string lookupValue = FirstMethod(table);
            
            Assert.AreEqual(lookupValue, "726");
        }
        [TestMethod]
        public void CodedUITestMethod2()
        {
            var bw = BrowserWindow.Launch(new Uri("http://localhost:2640/TableToSearch.html"));
            HtmlTable table = new HtmlTable(bw);
            table.SearchProperties.Add(HtmlTable.PropertyNames.Id, "LookupTable");

           
            string lookupValue = SecondMethod(table);

            Assert.AreEqual(lookupValue, "726");
        }
        [TestMethod]
        public void CodedUITestMethod3()
        {
            var bw = BrowserWindow.Locate("Local");
            HtmlTable table = new HtmlTable(bw);
            table.SearchProperties.Add(HtmlTable.PropertyNames.Id, "LookupTable");

            //string lookupValue = FirstMethod(table);
            string lookupValue = ThirdMethod(bw);

            Assert.AreEqual(lookupValue, "726");
        }
        private static string ThirdMethod(BrowserWindow browser)
        {
            HtmlCell directcell = new HtmlCell(browser);
            directcell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText,
             "lookupcolumn9", PropertyExpressionOperator.Contains));
            int cellIndex = directcell.ColumnIndex;

            HtmlRow directRow = new HtmlRow(browser);
            directRow.SearchProperties.Add(new PropertyExpression(HtmlRow.PropertyNames.InnerText,
             "Row 27", PropertyExpressionOperator.Contains));
            var lookupValue = directRow.Cells[cellIndex].FriendlyName;
            return lookupValue;
        }

        private static string SecondMethod(HtmlTable table)
        {
            string lookupValue = "";
            // find the index of the column we want to lookup in a row
            int columnIndex = -1;
            foreach (HtmlCell header in ((HtmlRow)(table.Rows[0])).Cells)
            {
                if (header.FriendlyName.Contains("lookupcolumn9"))
                {
                    columnIndex = header.ColumnIndex;
                    break;
                }
            }

            foreach (HtmlRow row in table.Rows)
            {

                if (row.Cells[0].FriendlyName.Contains("Row 27"))
                {
                    // get the value and return
                    lookupValue = row.Cells[columnIndex].FriendlyName;
                    break;
                }
            }
            return lookupValue;
        }

        private static string FirstMethod(HtmlTable table)
        {
            int nIndex = 0;
            for (nIndex = 0; nIndex < table.ColumnCount; nIndex++)
            {
                var headerCell = table.GetCell(0, nIndex);
                if (headerCell.FriendlyName.Contains("lookupcolumn9"))
                {
                    break; // nIndex is the column index we are looking for
                }
            }
            string lookupValue = "";
            int nRowIndex = 0;
            for (nRowIndex = 0; nRowIndex < table.Rows.Count; nRowIndex++)
            {
                var controlCell = table.GetCell(nRowIndex, 0);
                if (controlCell.FriendlyName.Contains("Row 27"))
                {
                    var cell = table.GetCell(nRowIndex, nIndex);
                    lookupValue = cell.FriendlyName;
                    break;
                }
            }
            return lookupValue;
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
