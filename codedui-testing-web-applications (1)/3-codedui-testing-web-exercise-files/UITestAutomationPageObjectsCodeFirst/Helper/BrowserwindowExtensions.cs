using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace UITestAutomationPageObjectsCodeFirst.Helper
{
    public static class BrowserWindowExtensions
    {
        public static HtmlControl FindElement(this BrowserWindow browserWindow, Func<BrowserWindow, HtmlControl> controlConstructorFunct)
        {
            return controlConstructorFunct(browserWindow);
        }

        public static UITestControlCollection FindElements(this BrowserWindow browserWindow, Func<BrowserWindow,HtmlControl> controlsConstructorFunct)
        {
            return controlsConstructorFunct(browserWindow).FindMatchingControls();
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hwndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        public static void resizeWindow(this BrowserWindow control , int width, int height)
        {
            //Call the native method to resize the window
            SetWindowPos(control.WindowHandle ,(IntPtr)(-1), 0, 0, width, height, 0x0002 | 0x0040);
        }



        public static void Click(this UITestControl control)
        {
            Mouse.Click(control);
        }

        public static void SendKeys(this UITestControl control, string text)
        {
            Keyboard.SendKeys(control, text);
        }

        
    }

    public class By
    {
        public static Func<BrowserWindow, HtmlControl> Id(string id)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.Id, id);
                return control;
            };
        }

        public static Func<BrowserWindow, HtmlControl> ClassName(string classNameToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.ClassName, classNameToFind);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> CssSelector(string cssSelectorToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.Class, cssSelectorToFind);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> Name(string nameToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.Name, nameToFind);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> LinkText(string linkTextToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlHyperlink(browserWindow);
                control.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText,linkTextToFind);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> PartialLinkText(string partialLinkTextToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText,partialLinkTextToFind,PropertyExpressionOperator.Contains);
                return control;
            };
        }
        public static Func<BrowserWindow, HtmlControl> TagName(string tagNameToFind)
        {
            return (browserWindow) =>
            {
                var control = new HtmlControl(browserWindow);
                control.SearchProperties.Add(HtmlControl.PropertyNames.TagName, tagNameToFind);
                return control;
            };
        }

    }
}
