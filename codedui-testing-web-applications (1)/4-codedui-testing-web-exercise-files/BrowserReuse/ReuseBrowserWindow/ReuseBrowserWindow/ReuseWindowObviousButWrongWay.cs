using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace ReuseBrowserWindow
{
    [CodedUITest]
    public class ReuseWindowObviousButWrongWay
    {
        static BrowserWindow _bw;

        [ClassInitialize]
        public static void initializeTest(TestContext context)
        {
            Playback.Initialize();
            _bw = BrowserWindow.Launch(new Uri("about:blank"));
            _bw.CloseOnPlaybackCleanup = false;
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            
            _bw.Close();
        }
        [TestMethod]
        public void CodedUITestMethodFirstTestBroken()
        {
            _bw.NavigateToUrl(new Uri("http://www.bing.com"));
            EnterSearchValue(_bw, "Pluralsight CodedUI training");
            ClickSearch(_bw);
        }

        [TestMethod]
        public void CodedUITestMethodSecondTestBroken()
        {
            _bw.NavigateToUrl(new Uri("http://www.bing.com"));
            EnterSearchValue(_bw, "Reuse BrowserWindow cross tests");
            ClickSearch(_bw);
        }

        [TestMethod]
        public void CodedUITestMethodThirdTestBroken()
        {
            _bw.NavigateToUrl(new Uri("http://www.bing.com"));
            EnterSearchValue(_bw, "CodedUI without UIMap");
            ClickSearch(_bw);
        }

        private static void ClickSearch(BrowserWindow _bw)
        {
            HtmlInputButton searchButton = new HtmlInputButton(_bw);
            searchButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "sb_form_go");
            Mouse.Click(searchButton);
        }

        private static void EnterSearchValue(BrowserWindow _bw, string value)
        {
            HtmlEdit searchBox = new HtmlEdit(_bw);
            searchBox.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "sb_form_q");
            searchBox.Text = value;
        }


    }
}
