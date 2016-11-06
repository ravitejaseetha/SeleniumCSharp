using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;

using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Diagnostics;


namespace infinitescroll
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestInfiniteScroll
    {
        public TestInfiniteScroll()
        {
        }

        [TestMethod]
        public void FindMarcelOnManifestoForSoftwarecraftsmanship()
        {
            var bw = BrowserWindow.Launch("http://manifesto.softwarecraftsmanship.org/");
 
            // CodedUI scrolls items into view before it can click them
            // this means we can use the waitfor control ready to get it to scroll
            // into view, and that trigegrs the reload of items
            // so we first access the table with id "signatory-table"
            // read the number of rows and access the last row and scroll it into view by 
            // activating the control
            bool notfound=true;
            int NumberOfpages = 0;
            while (notfound)
            {
                HtmlTable tbl = new HtmlTable(bw);
                tbl.SearchProperties.Add(HtmlTable.PropertyNames.Id, "signatory-table");
                // now disable a cache, since the table will grow on scroll
                // this does imply a performance hit, so we use it wisely!
                // do not ever iterate each row when cache is turned off, it will kill performance
                tbl.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                int rowcount = tbl.RowCount;
                // now get to the last row
                HtmlRow lastRow = (HtmlRow)tbl.Rows[rowcount - 1];
                // magic hapens here, this will scroll the row into view
                // triggering the load of the next page of data
                lastRow.EnsureClickable();
                
                NumberOfpages++;
                // and now we can get the next batch of items and do the same
                // untill we find my name "Marcel de Vries" somewhere in the table
                HtmlCell cell = new HtmlCell(tbl);
                cell.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, "Marcel de Vries", PropertyExpressionOperator.Contains);
                cell.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                if(cell.TryFind())
                {
                    notfound = false;
                    // we fall through and are done, we found my name!
                    // ok we found it, report back number of pages scrolled and
                    // row number we found the cell
                    Trace.WriteLine(string.Format("found name at page {0}",NumberOfpages));
                    Trace.WriteLine(string.Format("table row nr: {0}" ,cell.RowIndex));

                }
            }

            Assert.IsTrue(!notfound);
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
