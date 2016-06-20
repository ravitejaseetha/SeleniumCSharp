using SamplePoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePOC
{
    class Program
    {
        static void Main(string[] args)
        {
            // HtmlParser.DataFile1("Log");
            // HtmlParser.CreateHtml();

            //Using HtmlParser class file

            //string[] XmlPaths = Directory.GetFiles(Directory.GetCurrentDirectory()+@"\GuiMap");
            //string[] HtmlPaths = Directory.GetFiles(Directory.GetCurrentDirectory()+@"\Html");
            //HtmlParser.CreateHtml(XmlPaths, HtmlPaths);



            //Using ExcelParser class file

            ExcelParser excelParser = new ExcelParser();
            string XmlPaths1 = Directory.GetCurrentDirectory() + @"\GuiMap";
            string HtmlPaths1 = Directory.GetCurrentDirectory() + @"\Html";
            excelParser.CreateHtml(XmlPaths1, HtmlPaths1);
            List<string> sample = new List<string>();

            //List<string> val = XmlParser.GetValue(XmlPaths, "id", "name", "xpath", "classname", "tagname", "content", "attribute", "CssSelector");
        }
    }
}
