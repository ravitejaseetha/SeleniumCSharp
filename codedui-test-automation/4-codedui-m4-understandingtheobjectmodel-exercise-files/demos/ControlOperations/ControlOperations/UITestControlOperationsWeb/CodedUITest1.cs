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
using System.Diagnostics;


namespace UITestControlOperationsWeb
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
        public void ShowControlWaitActions()
        {
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t start");
            var browser = BrowserWindow.Launch(new Uri("http://localhost:9484/Main.html"));
            HtmlButton wb = new HtmlButton(browser);
            wb.SearchProperties.Add(HtmlButton.PropertyNames.Id, "Button1");
            Mouse.Click(wb);
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t Click");
            // now find the control that will apear after 5 seconds
            HtmlComboBox wl = new HtmlComboBox(browser);
            wl.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, "DynamicListbox");
            if (!wl.WaitForControlExist(7000))
            {
                Assert.Fail("Control not found that should be enabled by now");
            }
            // now click the button to wait for the control to become enabled
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t Found control ");

            HtmlButton wb2 = new HtmlButton(browser);
            wb2.SearchProperties.Add(HtmlButton.PropertyNames.Id, "Button2");
            Mouse.Click(wb2);
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t click btn 2 ");

            wl.WaitForControlEnabled(7000);
            wl.SelectedItem = "Blue";
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t blue selected ");

            HtmlButton wb3 = new HtmlButton(browser);
            wb3.SearchProperties.Add(HtmlButton.PropertyNames.Id, "Button3");
            Mouse.Click(wb3);
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t Click 3 ");

            if (wl.WaitForControlNotExist(7000))
            {
                // control is now gone, so assert true
                Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t Control removed ");

                Assert.IsTrue(true);
            }
            else { Assert.IsTrue(false); }



        }

        [TestMethod]
        public void ShowControlCondition()
        {
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t start");
            var browser = BrowserWindow.Launch(new Uri("http://localhost:9484/Main.html"));
            HtmlSpan span = new HtmlSpan(browser);
            span.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "txtTimerCountdown");
            // trigger the actual find now
            span.Find();
            //var text = span.InnerText;

            HtmlButton wb = new HtmlButton(browser);
            wb.SearchProperties.Add(HtmlButton.PropertyNames.Id, "Button1");
            Mouse.Click(wb);
            Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t Click" +text);
            // now wait for the control to reach status == 0
            Assert.IsTrue(span.WaitForControlCondition((control) => {
                var spancontrol = control as HtmlSpan;
                Debug.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:ss:mm") + "\t WaitForcontrolCondition called. Innertext==" + spancontrol.InnerText);
                return spancontrol.InnerText=="1"; }
                ,7000));
        }

        [TestMethod]
        public void SHowDifferentHtmlTableAproaches()
        {
            var browser = BrowserWindow.Launch(new Uri("http://localhost:9484/TableSample.html"));

            HtmlTable table = new HtmlTable(browser);
            table.SearchProperties.Add(HtmlTable.PropertyNames.Id, "NumberLookupTable");
            Stopwatch sw = new Stopwatch();


            string lookupValue = LookupColumnUseGetCel(table, sw);
            Assert.AreEqual(lookupValue, "784");

            lookupValue = LookupCellForEach(table, sw);
            Assert.AreEqual(lookupValue, "784");

            lookupValue = LookupCellDirectSearch(browser, sw);
            Assert.AreEqual(lookupValue, "784");

        }

        private static string LookupCellDirectSearch(BrowserWindow browser, Stopwatch sw)
        {
            // Get the correct cell direct using the search options of a control and
            // then get the accending cell with the correct value
            sw.Restart();

            HtmlCell directcell = new HtmlCell(browser);
            directcell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Lookupcolumn9", PropertyExpressionOperator.Contains));
            int cellIndex = directcell.ColumnIndex;

            HtmlRow directRow = new HtmlRow(browser);
            directRow.SearchProperties.Add(new PropertyExpression(HtmlRow.PropertyNames.InnerText, "rowLookup85", PropertyExpressionOperator.Contains));
            var lookupValue = directRow.Cells[cellIndex].FriendlyName;



            Debug.WriteLine("Third algorithm elapsed time for lookup:{0}", sw.ElapsedMilliseconds);
            return lookupValue;
        }

        private static string LookupColumnUseGetCel(HtmlTable table, Stopwatch sw)
        {
            sw.Restart();
            int nIndex = 0;
            for (nIndex = 0; nIndex < table.ColumnCount; nIndex++)
            {
                var headerCell = table.GetCell(0, nIndex);
                if (headerCell.FriendlyName.Contains("Lookupcolumn9"))
                {

                    break; // nIndex is the column index we are lookin for
                }
            }
            string lookupValue = "";
            int nRowIndex = 0;
            for (nRowIndex = 0; nRowIndex < table.Rows.Count; nRowIndex++)
            {
                var controlCell = table.GetCell(nRowIndex, 0);
                if (controlCell.FriendlyName.Contains("rowLookup85"))
                {
                    var cell = table.GetCell(nRowIndex, nIndex);
                    lookupValue = cell.FriendlyName;
                    break;
                }
            }

            Debug.WriteLine("first algorithm elapsed time for lookup:{0}", sw.ElapsedMilliseconds);
            return lookupValue;
        }

        private static string LookupCellForEach(HtmlTable table, Stopwatch sw)
        {
            sw.Restart();
            string lookupValue = "";
            // find the index of the column we want to lookup in a row
            int columnIndex = -1;
            foreach (HtmlCell header in ((HtmlRow)(table.Rows[0])).Cells)
            {
                if (header.FriendlyName.Contains("Lookupcolumn9"))
                {
                    columnIndex = header.ColumnIndex;
                    break;
                }
            }

            foreach (HtmlRow row in table.Rows)
            {

                if (row.Cells[0].FriendlyName.Contains("rowLookup85"))
                {
                    // get the value and return
                    lookupValue = row.Cells[columnIndex].FriendlyName;
                    break;
                }
            }

            Debug.WriteLine("seccond algorithm elapsed time for lookup:{0}", sw.ElapsedMilliseconds);


            return lookupValue;
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
