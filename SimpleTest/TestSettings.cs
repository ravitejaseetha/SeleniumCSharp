using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    public class TestSettings : BaseSettings
    {
        private static TestSettings defaultInstance = new TestSettings();
        private static string settingsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Config");
        private static string settingsFile;

        public static TestSettings Default
        {
            get
            {
                settingsFile = Path.Combine(settingsFilePath, "TestSettings.xml");
                return defaultInstance;
            }
        }

        string browser = "Firefox";
        public string Browser
        {
            get
            {
                string value = GetValue(settingsFile,"Browser");
                if(null != value)
                {
                    browser = value;
                }
                return browser;
            }
        }

        string urlValue = "";
        public string URL
        {
            get
            {
                string url = GetValue(settingsFile, "AUMCPUrl");
                if(null != url)
                {
                    urlValue = url; 
                }
                return urlValue;
            }
        }
    }
}
