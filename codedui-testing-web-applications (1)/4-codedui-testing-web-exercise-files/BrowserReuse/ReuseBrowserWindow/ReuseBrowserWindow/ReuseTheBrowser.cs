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


namespace ReuseBrowserWindow
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ReuseTheBrowser
    {
        static Process proc = null;

        [ClassInitialize]
        public static void initializeTest(TestContext context)
        {
            Playback.Initialize();
            var _bw = BrowserWindow.Launch(new Uri("about:blank"));
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            proc = _bw.Process;
            _bw.CloseOnPlaybackCleanup = false;
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            if(!Playback.IsInitialized)
                Playback.Initialize();
            
            BrowserWindow _bw = BrowserWindow.FromProcess(proc);
            _bw.Close();

            Playback.Cleanup();
        }

        [TestMethod]
        public void CodedUITestMethodFirstTest()
        {
            BrowserWindow _bw = BrowserWindow.FromProcess(proc);
            _bw.NavigateToUrl(new Uri("http://www.bing.com"));
            EnterSearchValue(_bw, "Pluralsight CodedUI training");
            ClickSearch(_bw);
        }


        [TestMethod]
        public void CodedUITestMethodSecondTest()
        {
            BrowserWindow _bw = BrowserWindow.FromProcess(proc);
            _bw.NavigateToUrl(new Uri("http://www.bing.com"));
            EnterSearchValue(_bw, "Reuse BrowserWindow cross tests");
            ClickSearch(_bw);
        }

        [TestMethod]
        public void CodedUITestMethodThirdTest()
        {
            BrowserWindow _bw = BrowserWindow.FromProcess(proc);
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
