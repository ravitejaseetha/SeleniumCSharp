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

            string[] XmlPaths = Directory.GetFiles(Directory.GetCurrentDirectory()+@"\GuiMap");
            //string[] HtmlPaths = Directory.GetFiles(Directory.GetCurrentDirectory()+@"\Html");
            //HtmlParser.CreateHtml(XmlPaths, HtmlPaths);



            //Using ExcelParser class file

            ExcelParser excelParser = new ExcelParser();
            string XmlPaths1 = Directory.GetCurrentDirectory() + @"\GuiMap";
            string HtmlPaths1 = Directory.GetCurrentDirectory() + @"\Html";
            excelParser.CreateHtml(XmlPaths1, HtmlPaths1);
            List<string> sample = new List<string>();

            //List<string> val = XmlParser.GetValue(XmlPaths, "id", "name", "xpath", "classname", "tagname", "content", "attribute", "CssSelector");



            Dictionary<string, Dictionary<string, GuiMap>> sample1 = GuiMapParser.GetInstance().LoadGuiMap(XmlPaths);
            int count = sample1.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(sample1.Keys.ElementAt(i));
                Dictionary<string, GuiMap> ne = sample1.Values.ElementAt(i);
                if (!(ne.Select(x => x.Value.Xpath).ToList() == null))
                {
                    ne.Select(x => new { x.Key, x.Value.Xpath }).ToList().ForEach(x => Console.WriteLine(x.Key + "\t" + x.Xpath));
                }
                if (!(ne.Select(x => x.Value.Id).ToList() == null))
                {
                    ne.Select(x => new { x.Key, x.Value.Id }).ToList().ForEach(x => Console.WriteLine(x.Key + "\t" + x.Id));
                }
            }
            Console.ReadKey();
        }
    }
}
